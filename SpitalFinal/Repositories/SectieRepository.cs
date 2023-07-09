using Microsoft.EntityFrameworkCore;
using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;

namespace SpitalFinal.Repositories
{
    public class SectieRepository : ISectieRepository
    {
        private readonly SpitalContext _context;

        public SectieRepository(SpitalContext context)
        {
            _context = context;
        }

        public Sectie? GetById(int id)
        {
            return _context.Secties.Find(id);
        }

        public void Add(Sectie product)
        {
            _context.Secties.Add(product);
        }

        public void Update(Sectie product)
        {
            _context.Secties.Update(product);
        }

        public void Delete(Sectie product)
        {
            _context.Secties.Remove(product);
        }
       


        public IEnumerable<Sectie> GetAll()
    {
        return _context.Secties.AsQueryable();
    } public IEnumerable<Sectie> GetAll1()
    {
        return _context.Secties.AsQueryable();
    }
    public void Save()
        {
            _context.SaveChanges();
        }
    }
}
