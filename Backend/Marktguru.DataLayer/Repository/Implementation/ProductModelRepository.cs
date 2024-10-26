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
    }
}