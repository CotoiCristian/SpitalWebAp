using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;
using SpitalFinal.Services.Interfaces;

namespace SpitalFinal.Services
{
    public class PacientService : IPacientService
    {
        private readonly IPacientRepository _productRepository;

        public PacientService(IPacientRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Pacient? GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public IEnumerable<Pacient> GetAll()
        {
            return _productRepository.GetAll();
        }

        public void Add(Pacient product)
        {
            _productRepository.Add(product);
            _productRepository.Save();
        }

        public void Update(Pacient product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
        }

        public void Delete(Pacient product)
        {
            _productRepository.Delete(product);
            _productRepository.Save();
        }
    }
}