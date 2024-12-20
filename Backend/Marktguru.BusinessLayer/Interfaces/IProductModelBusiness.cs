using System;
using Marktguru.BusinessLayer.BusinessEntities;

namespace Marktguru.BusinessLayer.Interfaces
{
    public interface IProductModelBusiness
    {
        Task<List<ShortProductModelDto>> GetProductModelsAsync();

        Task<FullProductModelDto?> GetProductByIdAsync(int id);

        Task<FullProductModelDto> AddNewProductAsync(FullProductModelDto newProduct);

        Task UpdateProductAsync(FullProductModelDto updateProduct);

        Task DeleteProductAsync(int id);
    }
}