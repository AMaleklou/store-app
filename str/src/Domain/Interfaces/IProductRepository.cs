using StoreApp.Domain.Entities;

namespace StoreApp.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<Product?> GetByIdAsync(Guid id);
        Task<List<Product>> GetAllAsync();
    }
}
