using SpitalFinal.Models;

namespace SpitalFinal.Services.Interfaces
{
    public interface ISectieService
    {
        Sectie? GetById(int id);
        IEnumerable<Sectie> GetAll(); // Add the GetAll method to retrieve all products
        IEnumerable<Sectie> GetAll1(); // Add the GetAll method to retrieve all products
        void Add(Sectie sectie);
        void Update(Sectie sectie);
        void Delete(Sectie sectie);
    }
}