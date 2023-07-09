using SpitalFinal.Models;

namespace SpitalFinal.Repositories.Interfaces
{
    public interface IFisaMedicRepository
    {
        FisaMedic? GetById(int id);
        IEnumerable<FisaMedic> GetAll();
        void Add(FisaMedic fisa);
        void Update(FisaMedic fisa);
        void Delete(FisaMedic fisa);
        void Save();
    }
}

