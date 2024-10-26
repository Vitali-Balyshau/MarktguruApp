using System;
using Marktguru.DataLayer.DataEntities;

namespace Marktguru.DataLayer.Repository.Interfaces
{
    public interface IProductModelRepository
    {
        Task<List<ProductModel>> GetAllProductsAsync();

        Task<ProductModel?> GetProductByIdAsync(int id);

        Task<int> AddNewProductModel(string productName, decimal preis, string description, bool available, DateTime creationDate);
    }
}