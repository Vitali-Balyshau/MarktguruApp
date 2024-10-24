using System;
using Marktguru.BusinessLayer.BusinessEntities;

namespace Marktguru.BusinessLayer.Interfaces
{
    public interface IProductModelBusiness
    {
        Task<List<ProductModelDto>> GetProductModelsAsync();
    }
}