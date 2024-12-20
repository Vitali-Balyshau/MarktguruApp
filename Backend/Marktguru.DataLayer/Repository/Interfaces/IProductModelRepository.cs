using System;
using Marktguru.DataLayer.DataEntities;

namespace Marktguru.DataLayer.Repository.Interfaces
{
    public interface IProductModelRepository
    {
        Task<List<ProductModel>> GetAllProductsAsync();

        Task<ProductModel?> GetProductByIdAsync(int id);

        Task<int> AddNewProductModel(string productName, decimal preis, string description, bool available, DateTime creationDate);

        Task<ProductModel?> GetProductByNameAsync(string productName);

        Task UpdateProductModelAsync(int id, string productName, decimal preis, string description, bool available, DateTime creationDate);

        Task DeleteProductAsync(int id);
    }
}