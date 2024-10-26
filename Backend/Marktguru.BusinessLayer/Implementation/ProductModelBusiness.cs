using System;
using Marktguru.BusinessLayer.BusinessEntities;
using Marktguru.BusinessLayer.Interfaces;
using Marktguru.DataLayer.Repository.Interfaces;
using Marktguru.DataLayer.DataEntities;
using Marktguru.BusinessLayer.Exceptions;
using Microsoft.EntityFrameworkCore;

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

        public async Task<FullProductModelDto> AddNewProductAsync(FullProductModelDto newProduct)
        {
            //Validate if product exists
            ProductModel? product = await _productModelRepository.GetProductByNameAsync(newProduct.ProductName);

            if (product != null)
            {
                throw new ProductAlreadyExistsException(product.ProductName);
            }

            DateTime productCreationDate = DateTime.Now;

            int newProductId = await _productModelRepository.AddNewProductModel(newProduct.ProductName, newProduct.Price, newProduct.Description, 
                newProduct.Available, productCreationDate);

            newProduct.Id = newProductId;
            newProduct.DateCreated = productCreationDate;

            return newProduct;
        }

        public async Task UpdateProductAsync(FullProductModelDto updateProduct)
        {
            ProductModel? product = await _productModelRepository.GetProductByIdAsync(updateProduct.Id);

            if (product == null)
            {
                throw new ProductDoesNotExistException(updateProduct.Id);
            }

            try
            {
                await _productModelRepository.UpdateProductModelAsync(updateProduct.Id, updateProduct.ProductName, updateProduct.Price, 
                    updateProduct.Description, updateProduct.Available, updateProduct.DateCreated);
            }
            catch(DbUpdateConcurrencyException ex)
            {
                throw new ConcurrencyDataUpdateConflictException("Product", ex);
            }
        }
    }
}