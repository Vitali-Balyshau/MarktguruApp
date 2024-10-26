using System;
using Marktguru.DataLayer.DataEntities;
using Marktguru.DataLayer.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Marktguru.DataLayer.Repository.Implementation
{
    public class ProductModelRepository: IProductModelRepository
    {
        private readonly DataContext _context;

        public ProductModelRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<ProductModel>> GetAllProductsAsync()
        {
            return await _context.ProductModels.ToListAsync();
        }

        public async Task<ProductModel?> GetProductByIdAsync(int id)
        {
            return await _context.ProductModels.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<int> AddNewProductModel(string productName, decimal preis, string description, bool available, DateTime creationDate)
        {
            int newProductId = -1;

            ProductModel newProduct = new ProductModel();

            newProduct.ProductName = productName;
            newProduct.Price = preis;
            newProduct.ProductDescription = description;
            newProduct.Available = available;
            newProduct.DateCreated = creationDate;

            _context.ProductModels.Add(newProduct);
            await _context.SaveChangesAsync();

            newProductId = newProduct.Id;

            return newProductId;
        }

        public async Task<ProductModel?> GetProductByNameAsync(string productName)
        {
            return await _context.ProductModels.Where(x => x.ProductName == productName).FirstOrDefaultAsync();
        }

        public async Task UpdateProductModelAsync(int id, string productName, decimal preis, string description, bool available, DateTime creationDate)
        {
            ProductModel? product = await _context.ProductModels.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (product != null)
            {
                product.ProductName = productName;
                product.Price = preis;
                product.ProductDescription = description;
                product.Available = available;
                product.DateCreated = creationDate;

                await _context.SaveChangesAsync();
            }
        }
    }
}