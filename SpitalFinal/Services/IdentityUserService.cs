using Microsoft.AspNetCore.Identity;
using SpitalFinal.Models;
using SpitalFinal.Repositories.Interfaces;
using SpitalFinal.Services.Interfaces;

namespace SpitalFinal.Services
{
    public class IdentityUserService : IIdentityUserService
    {
        private readonly IUserRepository _productRepository;

        public IdentityUserService(IUserRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IdentityUser? GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public IEnumerable<IdentityUser> GetAll()
        {
            return _productRepository.GetAll();
        }
        public IEnumerable<IdentityUser> GetAll1()
        {
            return _productRepository.GetAll1();
        }

        public void Add(IdentityUser product)
        {
            _productRepository.Add(product);
            _productRepository.Save();
        }

        public void Update(IdentityUser product)
        {
            _productRepository.Update(product);
            _productRepository.Save();
        }

        public void Delete(IdentityUser product)
        {
            _productRepository.Delete(product);
            _productRepository.Save();
        }
    }
}