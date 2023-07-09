using SpitalFinal.Models;

namespace SpitalFinal.Services.Interfaces
{
    public interface IPacientService
    {
        Pacient? GetById(int id);
        IEnumerable<Pacient> GetAll(); // Add the GetAll method to retrieve all products
        void Add(Pacient pacient);
        void Update(Pacient pacient);
        void Delete(Pacient pacient);
    }
}