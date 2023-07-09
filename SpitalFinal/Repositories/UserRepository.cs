using Microsoft.AspNetCore.Identity;
using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;

namespace SpitalFinal.Repositories
{
    public class UserRepository: IUserRepository
    {
        private readonly SpitalContext _context;

        public UserRepository(SpitalContext context)
        {
            _context = context;
        }

        public IdentityUser? GetById(int id)
        {
            return _context.IdentityUsers.Find(id);
        } 
     
        public void Add(IdentityUser product)
        {
            _context.IdentityUsers.Add(product);
        }

        public void Update(IdentityUser product)
        {
            _context.IdentityUsers.Update(product);
        }

        public void Delete(IdentityUser product)
        {
            _context.IdentityUsers.Remove(product);
        }



        public IEnumerable<IdentityUser> GetAll()
        {
            return _context.IdentityUsers.AsQueryable();
        }
        public IEnumerable<IdentityUser> GetAll1()
        {
            return _context.IdentityUsers.AsQueryable();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
