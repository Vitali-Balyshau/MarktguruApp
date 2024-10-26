using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Marktguru.BusinessLayer.Interfaces;
using Marktguru.BusinessLayer.BusinessEntities;

namespace Marktguru.WebAPI.Controllers
{
    public class ProductsController: BaseApiController
    {
        private readonly IProductModelBusiness _productBusiness;
        public ProductsController(IProductModelBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }

        [HttpGet("list")]
        public async Task<ActionResult<List<ShortProductModelDto>>> GetAllProductsAsync()
        {
            return await _productBusiness.GetProductModelsAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FullProductModelDto>> GetProductByIdAsync(int id)
        {
            FullProductModelDto? product = await _productBusiness.GetProductByIdAsync(id);

            if (product != null)
            {
                return product;
            }
            else
            {
                return NotFound();
            }
        }
    }
}