using Microsoft.EntityFrameworkCore;
using SpitalFinal.Models;

namespace SpitalFinal.Repositories.Interfaces
{
    public interface IProgramLucruRepository
    {
        ProgramLucru? GetById(int id);
        IQueryable<ProgramLucru> GetAll();
     
        public IEnumerable<ProgramLucru> GetAllNeutilizate();
        void Add(ProgramLucru programLucru);
        void Update(ProgramLucru programLucru);
        void Delete(ProgramLucru programLucru);
         
        void Save();
    }
}
