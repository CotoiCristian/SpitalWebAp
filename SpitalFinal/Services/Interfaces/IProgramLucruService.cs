using SpitalFinal.Models;

namespace SpitalFinal.Services.Interfaces
{
    public interface IProgramLucruService
    {
        ProgramLucru? GetById(int id);
        IEnumerable<ProgramLucru> GetAllNeutilizate(); 

        IEnumerable<ProgramLucru> GetAll();
        void Add(ProgramLucru programLucru);
        void Update(ProgramLucru programLucru);
        void Delete(ProgramLucru programLucru);
    }
}
