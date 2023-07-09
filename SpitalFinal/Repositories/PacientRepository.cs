using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;

namespace SpitalFinal.Repositories
{
    public class PacientRepository : IPacientRepository
    {
        private readonly SpitalContext _context;

        public PacientRepository(SpitalContext context)
        {
            _context = context;
        }

        public Pacient? GetById(int id)
        {
            return _context.Pacients.Find(id);
        }

        public void Add(Pacient product)
        {
            _context.Pacients.Add(product);
        }

        public void Update(Pacient product)
        {
            _context.Pacients.Update(product);
        }

        public void Delete(Pacient product)
        {
            _context.Pacients.Remove(product);
        }

        public IQueryable<Pacient> GetAll()
        {
            return _context.Pacients.AsQueryable();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
