using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Marktguru.BusinessLayer.Interfaces;
using Marktguru.BusinessLayer.BusinessEntities;

namespace Marktguru.WebAPI.Controllers
{
    public class ProductsController: BaseApiController
    {
        private readonly IProductModelBusiness _product;
        public ProductsController(IProductModelBusiness product)
        {
            _product = product;
        }

        [HttpGet("list")]
        public async Task<ActionResult<List<ProductModelDto>>> GetAllProductsAsync()
        {
            return await _product.GetProductModelsAsync();
        }
    }
}