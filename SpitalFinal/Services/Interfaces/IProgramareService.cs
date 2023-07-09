using SpitalFinal.Models;

namespace SpitalFinal.Services.Interfaces
{
    public interface IProgramareService
    {
        Programare? GetById(int id);
        IEnumerable<Programare> GetAll(); 
        void Add(Programare programare);
        void Update(Programare programare);
      
        void Delete(Programare programare);
       
    }
}