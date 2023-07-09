using SpitalFinal.Models;
using System.Security.Principal;

namespace SpitalFinal.Repositories.Interfaces
{
    public interface IWrapperRepository
    {

        IMedicRepository MedicRepository { get; }

        IPacientRepository PacientRepository { get; }

        IRetetaMedicalaRepository RetetaMedicalaRepository { get; }

        IFisaMedicRepository FisaMedicRepository { get; }

        IProgramareRepository ProgramareRepository { get; }

        ISectieRepository SectieRepository { get; }

        IProgramLucruRepository ProgramLucruRepository { get; }

        IInvestigatieRepository InvestigatieRepository { get; }

        IUserRepository UserRepository { get; }
        void Save();
    }
}