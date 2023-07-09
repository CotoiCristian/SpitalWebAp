using Microsoft.EntityFrameworkCore;
using NuGet.Versioning;
using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;

namespace SpitalFinal.Repositories
{
    public class FisaMedicRepository : IFisaMedicRepository
    {
        private readonly SpitalContext _context;

        public FisaMedicRepository(SpitalContext context)
        {
            _context = context;
        }

        public FisaMedic? GetById(int id)
        {
            return  _context.FisaMedics
            .Include(f => f.Medic)
            .Include(f => f.Pacient)
            .Include(f => f.RetetaMedicala)
            .FirstOrDefault(m => m.FisaMedicId == id);
        }

        public void Add(FisaMedic product)
        {
            _context.FisaMedics.Add(product);
        }

        public void Update(FisaMedic product)
        {
            _context.FisaMedics.Update(product);
        }

        public void Delete(FisaMedic product)
        {
            _context.FisaMedics.Remove(product);
        }

        public IEnumerable<FisaMedic> GetAll()
        {
            return _context.FisaMedics
                .Include(f => f.Medic)
                .Include(f => f.Pacient)
                .Include(f => f.RetetaMedicala);
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
