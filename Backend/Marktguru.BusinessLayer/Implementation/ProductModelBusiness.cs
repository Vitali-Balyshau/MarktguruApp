using System;
using Marktguru.BusinessLayer.BusinessEntities;
using Marktguru.BusinessLayer.Interfaces;
using Marktguru.DataLayer.Repository.Interfaces;
using Marktguru.DataLayer.DataEntities;

namespace Marktguru.BusinessLayer.Implementation
{
    public class ProductModelBusiness : IProductModelBusiness
    {
        private readonly IProductModelRepository _productModelRepository;

        public ProductModelBusiness(IProductModelRepository productModelRepository)
        {
            _productModelRepository = productModelRepository;
        }

        public async Task<List<ProductModelDto>> GetProductModelsAsync()
        {
            List<ProductModelDto> result = new List<ProductModelDto>();
            
            List<ProductModel> dataEntities = await _productModelRepository.GetAllProductsAsync();

            //Can be done by AutoMapper
            result = dataEntities.Select(x => new ProductModelDto() {
                Id = x.Id,
                ProductName = x.ProductName,
                Price = x.Price,
                Available = x.Available,
                ProductDescription = x.ProductDescription,
                DateCreated = x.DateCreated,
            }).ToList();

            return result;
        }
    }
}