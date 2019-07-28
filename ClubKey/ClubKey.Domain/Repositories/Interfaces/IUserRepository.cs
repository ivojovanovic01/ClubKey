using ClubKey.Data.Entities.Models;

namespace ClubKey.Domain.Repositories.Interfaces
{
    public interface IUserRepository
    {
        int AddUser(User userToAdd);
        User GetUserByUsername(string username);
    }
}