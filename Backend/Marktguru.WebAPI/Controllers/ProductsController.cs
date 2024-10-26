using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Marktguru.BusinessLayer.Interfaces;
using Marktguru.BusinessLayer.BusinessEntities;
using Marktguru.BusinessLayer.Exceptions;

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
            return Ok(await _productBusiness.GetProductModelsAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FullProductModelDto>> GetProductByIdAsync(int id)
        {
            FullProductModelDto? product = await _productBusiness.GetProductByIdAsync(id);

            if (product != null)
            {
                return Ok(product);
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize]
        [HttpPost("add")]
        public async Task<ActionResult<FullProductModelDto>> AddNewProductAsync(FullProductModelDto newProduct)
        {
            try
            {
                FullProductModelDto addedProduct = await _productBusiness.AddNewProductAsync(newProduct);

                return Ok(addedProduct);
            }
            catch(ProductAlreadyExistsException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize]
        [HttpPut("update/{id}")]
        public async Task<ActionResult<FullProductModelDto>> UpdateProductAsync(int id, [FromBody]FullProductModelDto updateProduct)
        {
            try
            {
                updateProduct.Id = id;

                await _productBusiness.UpdateProductAsync(updateProduct);

                return NoContent();
            }
            catch(ProductDoesNotExistException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(ConcurrencyDataUpdateConflictException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}