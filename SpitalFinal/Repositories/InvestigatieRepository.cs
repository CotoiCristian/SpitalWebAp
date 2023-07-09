using Microsoft.EntityFrameworkCore;
using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;

namespace SpitalFinal.Repositories
{
    public class InvestigatieRepository : IInvestigatieRepository
    {
        private readonly SpitalContext _context;

        public InvestigatieRepository(SpitalContext context)
        {
            _context = context;
        }

        public Investigatie? GetById(int id)
        {
            var investi =  _context.Investigaties.Include(m => m.FisaMedic).FirstOrDefault(d => d.InvestigatieId == id);
            return investi;
        }

        public void Add(Investigatie product)
        {
            _context.Investigaties.Add(product);
        }

        public void Update(Investigatie product)
        {
            _context.Investigaties.Update(product);
        }

        public void Delete(Investigatie product)
        {
            _context.Investigaties.Remove(product);
        }

        public IQueryable<Investigatie> GetAll()
        {
            return _context.Investigaties.Include(i => i.FisaMedic);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
