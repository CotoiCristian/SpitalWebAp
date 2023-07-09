using SpitalFinal.Models;

namespace SpitalFinal.Repositories.Interfaces
{
    public interface IPacientRepository
    {
        Pacient? GetById(int id);
        IQueryable<Pacient> GetAll();
        void Add(Pacient pacient);
        void Update(Pacient pacient);
        void Delete(Pacient pacient);
        void Save();
    }
}
