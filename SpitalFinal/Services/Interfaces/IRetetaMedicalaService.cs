using SpitalFinal.Models;

namespace SpitalFinal.Services.Interfaces
{
    public interface IRetetaMedicalaService
    {
        RetetaMedicala? GetById(int id);
        IEnumerable<RetetaMedicala> GetAll(); // Add the GetAll method to retrieve all products
        void Add(RetetaMedicala retetaMedicala);
        void Update(RetetaMedicala retetaMedicala);
        void Delete(RetetaMedicala retetaMedicala);
    }
}