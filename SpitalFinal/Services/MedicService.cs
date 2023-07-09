using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;
using SpitalFinal.Services.Interfaces;

namespace SpitalFinal.Services
{
    public class MedicService : IMedicService
    {
        private readonly IMedicRepository _productRepository;

        public MedicService(IMedicRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Medic? GetById(int id)
        {
            return _productRepository.GetById(id);
        }  public Medic? GetByIdDetils(int id)
        {
            return _productRepository.GetByIdDetils(id);
        }

        public IEnumerable<Medic> GetAll()
        {
            return _productRepository.GetAll();
        }  
          public IEnumerable<Medic> GetAll1()
        {
            return _productRepository.GetAll1();
        }

        public void Add(Medic product)
        {
            _productRepository.Add(product);
            _productRepository.Save();
        }

        public void Update(Medic product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
        }

        public void Delete(Medic product)
        {
            _productRepository.Delete(product);
            _productRepository.Save();
        }
    }
}