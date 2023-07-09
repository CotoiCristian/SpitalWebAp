using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;
using System.Linq;

namespace SpitalFinal.Repositories
{
    public class ProgramareRepository : IProgramareRepository
    {
        private readonly SpitalContext _context;

        public ProgramareRepository(SpitalContext context)
        {
            _context = context;
        }
    

        public Programare? GetById(int id)
        {
         
            var v =  _context.Programares
                .Include(f => f.Medic)
                .Include(f => f.ProgramLucru)
                .FirstOrDefault(d => d.ProgramareId == id);
            return v;
        }
        public bool IsProgramLucruUnique(int ID)
        {
            return !_context.Programares.Any(u => u.ProgramLucruId == ID);
        }
        public void Add(Programare product)
        {
            if (IsProgramLucruUnique(product.ProgramLucruId))
            {
                _context.Programares.Add(product);
            }

        }


        public void Update(Programare product)
        {
            _context.Programares.Update(product);
        }

        public void Delete(Programare product)
        {
            _context.Programares.Remove(product);
        }

        public IQueryable<Programare> GetAll()
        {

            return  _context.Programares.Include(m => m.Medic).Include(m => m.ProgramLucru).AsQueryable(); 
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}