using ClubKey.Data.Entities.Models;

namespace ClubKey.Domain.Repositories.Interfaces
{
    public interface IOwnerRepository
    {
        Owner GetOwnerByUsername(string ownerUsername);
    }
}