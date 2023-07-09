using Microsoft.EntityFrameworkCore;
using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;
using SpitalFinal.Services.Interfaces;

namespace SpitalFinal.Services
{
    public class ProgramLucruService : IProgramLucruService
    {
        private readonly IProgramLucruRepository _productRepository;

        public ProgramLucruService(IProgramLucruRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProgramLucru? GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public IEnumerable<ProgramLucru> GetAll()
        {
            return _productRepository.GetAll();
        }   
        public IEnumerable<ProgramLucru> GetAllNeutilizate()
        {
            return _productRepository.GetAllNeutilizate();
        }
        public void Add(ProgramLucru product)
        {
            _productRepository.Add(product);
            _productRepository.Save();
        }

        public void Update(ProgramLucru product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
        }

        public void Delete(ProgramLucru product)
        {
            _productRepository.Delete(product);
            _productRepository.Save();
        }
    }
}