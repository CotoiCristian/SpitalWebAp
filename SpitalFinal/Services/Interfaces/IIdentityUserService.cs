using Microsoft.AspNetCore.Identity;
using SpitalFinal.Models;

namespace SpitalFinal.Services.Interfaces
{
    public interface IIdentityUserService
    {
        IdentityUser? GetById(int id);
        IEnumerable<IdentityUser> GetAll(); // Add the GetAll method to retrieve all products
        IEnumerable<IdentityUser> GetAll1(); // Add the GetAll method to retrieve all products
        void Add(IdentityUser sectie);
        void Update(IdentityUser sectie);
        void Delete(IdentityUser sectie);
    }
}