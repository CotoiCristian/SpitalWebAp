using SpitalFinal.Models;

namespace SpitalFinal.Services.Interfaces
{
    public interface IInvestigatieService
    {
        Investigatie? GetById(int id);
        IEnumerable<Investigatie> GetAll(); // Add the GetAll method to retrieve all products
        void Add(Investigatie investi);
        void Update(Investigatie investi);
        void Delete(Investigatie investi);
    }
}