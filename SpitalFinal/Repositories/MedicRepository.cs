using Microsoft.EntityFrameworkCore;
using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;

namespace SpitalFinal.Repositories
{
    public class MedicRepository : IMedicRepository
    {
        private readonly SpitalContext _context;

        public MedicRepository(SpitalContext context)
        {
            _context = context;
        }

        public Medic? GetByIdDetils(int id)
        {

            var d =  _context.Medics.Include(m => m.Sectie)
                       .FirstOrDefault(d => d.MedicId == id);
            
            return d; 

        }
        public IEnumerable<ProgramLucru> GetAllNeutilizate()
        {
            if (_context.Programares == null)
                return _context.ProgramLucrus;

            return _context.ProgramLucrus
                .Where(p => p.Programares == null || !p.Programares.Any(m => m.ProgramLucruId == p.ProgramLucruId));
        }

        public Medic? GetById(int id)
        {
  
            return _context.Medics.Find(id); 

        }

        public void Add(Medic product)
        {
            _context.Medics.Add(product);
        }

        public void Update(Medic product)
        {
            _context.Medics.Update(product);
        }

        public void Delete(Medic product)
        {
            _context.Medics.Remove(product);
        }
       

        public IEnumerable<Medic> GetAll()
        {
            var spitalContext = _context.Medics.Include(m => m.Sectie);
            return  spitalContext;
           
        } public IEnumerable<Medic> GetAll1()
        {
            return _context.Medics.AsQueryable();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}