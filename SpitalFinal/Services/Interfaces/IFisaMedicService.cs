using SpitalFinal.Models;

namespace SpitalFinal.Services.Interfaces
{
    public interface IFisaMedicService
    {
        FisaMedic? GetById(int id);
        IEnumerable<FisaMedic> GetAll(); // Add the GetAll method to retrieve all products
        void Add(FisaMedic product);
        void Update(FisaMedic product);
        void Delete(FisaMedic product);
    }
}