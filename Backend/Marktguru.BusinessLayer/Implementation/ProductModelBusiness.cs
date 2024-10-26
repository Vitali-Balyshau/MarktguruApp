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

        public async Task<FullProductModelDto?> GetProductByIdAsync(int id)
        {
            FullProductModelDto? result = null;

            ProductModel? product = await _productModelRepository.GetProductByIdAsync(id);

            if (product != null)
            {
                //Can be done by AutoMapper
                result = new FullProductModelDto();
                result.Id = product.Id;
                result.ProductName = product.ProductName;
                result.Available = product.Available;
                result.Description = product.ProductDescription;
                result.Price = product.Price;
                result.DateCreated = product.DateCreated;
            }

            return result;
        }

        public async Task<List<ShortProductModelDto>> GetProductModelsAsync()
        {
            List<ShortProductModelDto> result = new List<ShortProductModelDto>();
            
            List<ProductModel> dataEntities = await _productModelRepository.GetAllProductsAsync();

            //Can be done by AutoMapper
            result = dataEntities.Select(x => new ShortProductModelDto() {
                Id = x.Id,
                ProductName = x.ProductName,
                Price = x.Price,
                Available = x.Available,
            }).ToList();

            return result;
        }
    }
}