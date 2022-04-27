using Microsoft.AspNetCore.Mvc;
using RestWithDDD.Application.DTOs;
using RestWithDDD.Application.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestWithDDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IApplicationServiceClient _serviceClient;

        public ClientController(IApplicationServiceClient serviceClient)
        {
            _serviceClient = serviceClient;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientDTO>>> Get()
        {
            return Ok(await _serviceClient.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientDTO>> GetById(int id)
        {
            return Ok(await _serviceClient.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ClientDTO dto)
        {
            await _serviceClient.Add(dto);
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] ClientDTO dto)
        {
            if (dto == null) return NotFound();

            await _serviceClient.Update(dto);

            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete([FromBody] ClientDTO dto)
        {
            if (dto == null) return NotFound();

            await _serviceClient.Delete(dto);

            return NoContent();
        }
    }
}
