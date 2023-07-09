using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;
using SpitalFinal.Services.Interfaces;

namespace SpitalFinal.Services
{
    public class RetetaMedicalaService : IRetetaMedicalaService
    {
        private readonly IRetetaMedicalaRepository _productRepository;

        public RetetaMedicalaService(IRetetaMedicalaRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        public RetetaMedicala GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public IEnumerable<RetetaMedicala> GetAll()
        {
            return _productRepository.GetAll();
        }

        public void Add(RetetaMedicala product)
        {
            _productRepository.Add(product);
            _productRepository.Save();
        }

        public void Update(RetetaMedicala product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
        }

        public void Delete(RetetaMedicala product)
        {
            _productRepository.Delete(product);
            _productRepository.Save();
        }
    }
}