using Microsoft.AspNetCore.Identity;
using SpitalFinal.Models;

namespace SpitalFinal.Repositories.Interfaces
{
    public interface IUserRepository
    {
        IdentityUser? GetById(int id);
        IEnumerable<IdentityUser> GetAll();
        IEnumerable<IdentityUser> GetAll1();

        void Add(IdentityUser sectie);
        void Update(IdentityUser sectie);
        void Delete(IdentityUser sectie);
        void Save();
    }
}