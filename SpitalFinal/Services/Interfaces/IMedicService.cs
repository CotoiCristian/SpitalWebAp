using SpitalFinal.Models;

namespace SpitalFinal.Services.Interfaces
{
    public interface IMedicService
    {
        Medic? GetById(int id);
        Medic? GetByIdDetils(int id);
        IEnumerable<Medic> GetAll(); // Add the GetAll method to retrieve all products
   // Add the GetAll method to retrieve all products
        IEnumerable<Medic> GetAll1();
        void Add(Medic medic);
        void Update(Medic medic);
        void Delete(Medic medic);
    }
}