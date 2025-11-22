using StoreApp.Domain.Entities;
using StoreApp.Domain.Interfaces;

namespace StoreApp.Application.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repo;
        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task<Product> CreateProductAsync(string name, decimal price)
        {
            var product = new Product(name, price);
            await _repo.AddAsync(product);
            return product;
        }
    }
}
