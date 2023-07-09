using SpitalFinal.Models;

namespace SpitalFinal.Repositories.Interfaces
{
    public interface ISectieRepository
    {
        Sectie? GetById(int id);
        IEnumerable<Sectie> GetAll();
        IEnumerable<Sectie> GetAll1();
       
        void Add(Sectie sectie);
        void Update(Sectie sectie);
        void Delete(Sectie sectie);
        void Save();
    }
}
