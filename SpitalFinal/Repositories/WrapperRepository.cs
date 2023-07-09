using Microsoft.EntityFrameworkCore;
using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;

namespace SpitalFinal.Repositories
{
    public class WrapperRepository : IWrapperRepository
    {
        private SpitalContext _spitalContext;
        private IMedicRepository? _medicRepository;
        private IPacientRepository? _pacientRepository;
        private IRetetaMedicalaRepository? _retetaMedicalaRepository;
        private IFisaMedicRepository? _fisaMedicRepository;
        private IProgramareRepository? _programareRepository;
        private ISectieRepository? _sectieRepository;
        private IProgramLucruRepository? _programLucrurRepository;
        private IInvestigatieRepository? _investigatieRepository;
        private IUserRepository? _userRepository;
        public WrapperRepository(SpitalContext context)
        {
            _spitalContext = context;
        }

        public IMedicRepository MedicRepository
        {
            get
            {
                if (_medicRepository == null)
                {
                    _medicRepository = new MedicRepository(_spitalContext);
                }

                return _medicRepository;
            }
        }
        public IInvestigatieRepository InvestigatieRepository
        {
            get
            {
                if (_investigatieRepository == null)
                {
                    _investigatieRepository = new InvestigatieRepository(_spitalContext);
                }

                return _investigatieRepository;
            }
        }
        public IProgramLucruRepository ProgramLucruRepository
        {
            get
            {
                if (_programLucrurRepository == null)
                {
                    _programLucrurRepository = new ProgramLucruRepository(_spitalContext);
                }

                return _programLucrurRepository;
            }
        }
        public ISectieRepository SectieRepository
        {
            get
            {
                if (_sectieRepository == null)
                {
                    _sectieRepository = new SectieRepository(_spitalContext);
                }

                return _sectieRepository;
            }
        }
        public IProgramareRepository ProgramareRepository
        {
            get
            {
                if (_programareRepository == null)
                {
                    _programareRepository = new ProgramareRepository(_spitalContext);
                }

                return _programareRepository;
            }
        }
        public IFisaMedicRepository FisaMedicRepository
        {
            get
            {
                if (_fisaMedicRepository == null)
                {
                    _fisaMedicRepository = new FisaMedicRepository(_spitalContext);
                }

                return _fisaMedicRepository;
            }
        }
        public IRetetaMedicalaRepository RetetaMedicalaRepository
        {
            get
            {
                if (_retetaMedicalaRepository == null)
                {
                    _retetaMedicalaRepository = new RetetaMedicalaRepository(_spitalContext);
                }

                return _retetaMedicalaRepository;
            }
        }
        public IPacientRepository PacientRepository
        {
            get
            {
                if (_pacientRepository == null)
                {
                    _pacientRepository = new PacientRepository(_spitalContext);
                }

                return _pacientRepository;
            }
        }  
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_spitalContext);
                }

                return _userRepository;
            }
        }
        

        public void Save()
        {
            _spitalContext.SaveChanges();
        }
    }
}
