using System;
using Marktguru.DataLayer.DataEntities;

namespace Marktguru.DataLayer.Repository.Interfaces
{
    public interface IProductModelRepository
    {
        Task<List<ProductModel>> GetAllProductsAsync();

        Task<ProductModel?> GetProductByIdAsync(int id);
    }
}