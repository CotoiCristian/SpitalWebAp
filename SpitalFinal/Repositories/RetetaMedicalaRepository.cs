using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;

namespace SpitalFinal.Repositories
{
    public class RetetaMedicalaRepository : IRetetaMedicalaRepository
    {
        private readonly SpitalContext _context;

        public RetetaMedicalaRepository(SpitalContext context)
        {
            _context = context;
        }

        public RetetaMedicala? GetById(int id)
        {
            return _context.RetetaMedicals.Find(id);
        }
     

        public void Add(RetetaMedicala product)
        {
            _context.RetetaMedicals.Add(product);
        }

        public void Update(RetetaMedicala product)
        {
            _context.RetetaMedicals.Update(product);
        }

        public void Delete(RetetaMedicala product)
        {
            _context.RetetaMedicals.Remove(product);
        }

        public IQueryable<RetetaMedicala> GetAll()
        {
            return _context.RetetaMedicals.AsQueryable();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
