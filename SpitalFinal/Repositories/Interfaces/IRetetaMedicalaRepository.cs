using SpitalFinal.Models;

namespace SpitalFinal.Repositories.Interfaces
{
    public interface IRetetaMedicalaRepository
    {
        RetetaMedicala? GetById(int id);
        IQueryable<RetetaMedicala> GetAll();
        void Add(RetetaMedicala retetaMedicala);
        void Update(RetetaMedicala retetaMedicala);
        void Delete(RetetaMedicala retetaMedicala);
        void Save();
    }
}
