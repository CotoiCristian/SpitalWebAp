using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;
using SpitalFinal.Services.Interfaces;

namespace SpitalFinal.Services
{
    public class FisaMedicalaService : IFisaMedicService
    {
        private readonly IFisaMedicRepository _productRepository;

        public FisaMedicalaService(IFisaMedicRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public FisaMedic? GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public IEnumerable<FisaMedic> GetAll()
        {
            return _productRepository.GetAll();
        }

        public void Add(FisaMedic product)
        {
            _productRepository.Add(product);
            _productRepository.Save();
        }

        public void Update(FisaMedic product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
        }

        public void Delete(FisaMedic product)
        {
            _productRepository.Delete(product);
            _productRepository.Save();
        }
    }
}