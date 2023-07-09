using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;
using SpitalFinal.Services.Interfaces;

namespace SpitalFinal.Services
{
    public class InvestigatieService : IInvestigatieService
    {
        private readonly IInvestigatieRepository _productRepository;

        public InvestigatieService(IInvestigatieRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Investigatie? GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public IEnumerable<Investigatie> GetAll()
        {
            return _productRepository.GetAll();
        }

        public void Add(Investigatie product)
        {
            _productRepository.Add(product);
            _productRepository.Save();
        }

        public void Update(Investigatie product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
        }

        public void Delete(Investigatie product)
        {
            _productRepository.Delete(product);
            _productRepository.Save();
        }
    }
}