using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;
using SpitalFinal.Services.Interfaces;

namespace SpitalFinal.Services
{
    public class SectieService : ISectieService
    {
        private readonly ISectieRepository _productRepository;

        public SectieService(ISectieRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Sectie? GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public IEnumerable<Sectie> GetAll()
        {
            return _productRepository.GetAll();
        }
        public IEnumerable<Sectie> GetAll1()
        {
            return _productRepository.GetAll1();
        }

        public void Add(Sectie product)
        {
            _productRepository.Add(product);
            _productRepository.Save();
        }

        public void Update(Sectie product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
        }

        public void Delete(Sectie product)
        {
            _productRepository.Delete(product);
            _productRepository.Save();
        }
    }
}