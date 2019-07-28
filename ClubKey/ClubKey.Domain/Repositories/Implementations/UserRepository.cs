using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ClubKey.Data.Entities;
using ClubKey.Data.Entities.Models;
using ClubKey.Domain.Repositories.Interfaces;

namespace ClubKey.Domain.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(ClubKeyContext context)
        {
            _context = context;
        }
        private readonly ClubKeyContext _context;
        public int AddUser(User userToAdd)
        {
            if (!IsUserValid(userToAdd)) // need image validation
                return 0;

            _context.Users.Add(userToAdd);

            foreach (var achievement in _context.Achievements)
                _context.UserAchievements.Add(new UserAchievement(userToAdd, achievement));

            _context.SaveChanges();
            return userToAdd.Id;
        }
        public User GetUserByUsername(string username)
        {
            return _context.Users.FirstOrDefault(user => user.Username == username);
        }
        private bool IsUsernameUnique(User testUser) => 
            _context.Users.All(user => user.Username != testUser.Username && user.Id == testUser.Id);
        private static bool IsUsernameValid(string username) => Regex.IsMatch(username, "^[a-z0-9_-]{3,25}$");
        private static bool IsPasswordValid(string password) =>
            Regex.IsMatch(password, "^(?=.*[a - z])(?=.*[A - Z])(?=.*\\d)[a - zA - Z\\d]{ 8,}$");
        private static bool IsNameValid(string name) => name.Length >= 3;
        private static bool IsEmailValid(string email) =>
            Regex.IsMatch(email, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        private static bool HasUserTickets(IEnumerable<Ticket> userTickets) => userTickets.Any();
        private bool IsUserValid(User user) =>
            IsUsernameUnique(user) &&
            IsUsernameValid(user.Username) &&
            IsPasswordValid(user.Password) &&
            IsNameValid(user.FirstName) &&
            IsNameValid(user.LastName) &&
            IsEmailValid(user.Email) &&
            HasUserTickets(user.Tickets);
    }
}
