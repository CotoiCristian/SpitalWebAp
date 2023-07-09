using Microsoft.AspNetCore.Http.HttpResults;
using SpitalFinal.Models;
using SpitalFinal.Repositories;
using SpitalFinal.Repositories.Interfaces;
using SpitalFinal.Services.Interfaces;

namespace SpitalFinal.Services
{
    public class ProgramareService : IProgramareService
    {
        private readonly IProgramareRepository _productRepository;

        public ProgramareService(IProgramareRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public  Programare? GetById(int id)
        {
            return _productRepository.GetById(id);
        }
     

        public IEnumerable<Programare> GetAll()
        {
            return _productRepository.GetAll();
        }
        //public IEnumerable<ProgramLucru> GetProgramariDisponibile()
        //{
        //    return _productRepository.GetAll();
        //}
        
        public void Add(Programare product)
        {
            //if (_productRepository.IsProgramLucruUnique(product.ProgramLucruId))
            //{
                _productRepository.Add(product);
                _productRepository.Save();
            //}
            //else
            //{
            //   //ddsd
            //}
        }

        public void Update(Programare product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
        }

        public void Delete(Programare product)
        {
            _productRepository.Delete(product);
            _productRepository.Save();
        }
    }
}