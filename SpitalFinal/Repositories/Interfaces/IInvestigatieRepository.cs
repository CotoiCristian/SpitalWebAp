using SpitalFinal.Models;

namespace SpitalFinal.Repositories.Interfaces
{
    public interface IInvestigatieRepository
    {
        Investigatie? GetById(int id);
        IQueryable<Investigatie> GetAll();
        void Add(Investigatie fisa);
        void Update(Investigatie fisa);
        void Delete(Investigatie fisa);
        void Save();
    }
}

