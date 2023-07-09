using Microsoft.EntityFrameworkCore;
using SpitalFinal.Controllers;
using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;

namespace SpitalFinal.Repositories
{
    public class ProgramLucruRepository : IProgramLucruRepository
    {


        private readonly SpitalContext _context;


        public ProgramLucruRepository(SpitalContext context)
        {
            _context = context;


        }


        public ProgramLucru? GetById(int id)
        {
            return _context.ProgramLucrus.Find(id);
        }

        public void Add(ProgramLucru product)
        {
            _context.ProgramLucrus.Add(product);
        }

        public void Update(ProgramLucru product)
        {
            _context.ProgramLucrus.Update(product);
        }

        public IEnumerable<ProgramLucru> GetAllNeutilizate()
        {
            if (_context.Programares == null)
                return _context.ProgramLucrus;

            return _context.ProgramLucrus
                .Where(p => p.Programares == null || !p.Programares.Any(m => m.ProgramLucruId == p.ProgramLucruId));
        }
     

        public void Delete(ProgramLucru product)
        {
            _context.ProgramLucrus.Remove(product);
        }
      

        public IQueryable<ProgramLucru> GetAll()
        {
            return _context.ProgramLucrus;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
