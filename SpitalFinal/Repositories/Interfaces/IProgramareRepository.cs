using SpitalFinal.Models;

namespace SpitalFinal.Repositories.Interfaces
{
    public interface IProgramareRepository
    {
        Programare? GetById(int id);
        IQueryable<Programare> GetAll();
        void Add(Programare programare);
        void Update(Programare programare);
        void Delete(Programare programare);
        bool IsProgramLucruUnique(int ID);

        void Save();
    }
}
