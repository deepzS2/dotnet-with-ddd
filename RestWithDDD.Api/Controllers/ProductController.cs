using Microsoft.AspNetCore.Mvc;
using RestWithDDD.Application.DTOs;
using RestWithDDD.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestWithDDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IApplicationServiceProduct _serviceProduct;

        public ProductController(IApplicationServiceProduct serviceProduct)
        {
            _serviceProduct = serviceProduct;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> Get()
        {
            return Ok(await _serviceProduct.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetById(int id)
        {
            return Ok(await _serviceProduct.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProductDTO dto)
        {
            await _serviceProduct.Add(dto);
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ProductDTO dto)
        {
            if (dto == null) return NotFound();

            await _serviceProduct.Update(dto);

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] ProductDTO dto)
        {
            if (dto == null) return NotFound();

            await _serviceProduct.Delete(dto);

            return NoContent();
        }
    }
}
