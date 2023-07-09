using SpitalFinal.Models;

namespace SpitalFinal.Repositories.Interfaces
{
    public interface IMedicRepository
    {
        Medic? GetById(int id);
        Medic? GetByIdDetils(int id);
        IEnumerable<Medic> GetAll();
        IEnumerable<Medic> GetAll1();
        void Add(Medic medic);
        void Update(Medic medic);
        void Delete(Medic medic);
        void Save();
    }
}
