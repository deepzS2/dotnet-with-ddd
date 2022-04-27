using RestWithDDD.Application.DTOs;
using RestWithDDD.Application.Interfaces;
using RestWithDDD.Application.Mappers.Interfaces;
using RestWithDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestWithDDD.Application
{
    public class ApplicationServiceProduct : IApplicationServiceProduct
    {
        private readonly IServiceProduct _service;
        private readonly IMapperProduct _mapper;

        public ApplicationServiceProduct(IServiceProduct service, IMapperProduct mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task Add(ProductDTO dto)
        {
            var product = _mapper.MapperDtoToEntity(dto);
            await _service.Add(product);
        }

        public async Task Delete(ProductDTO dto)
        {
            var product = _mapper.MapperDtoToEntity(dto);
            await _service.Delete(product);
        }

        public async Task<IEnumerable<ProductDTO>> GetAll()
        {
            var product = await _service.GetAll();
            return _mapper.MapperEntityListToDto(product);
        }

        public async Task<ProductDTO> GetById(int id)
        {
            var product = await _service.GetById(id);
            return _mapper.MapperEntityToDto(product);
        }

        public async Task Update(ProductDTO dto)
        {
            var product = _mapper.MapperDtoToEntity(dto);
            await _service.Update(product);
        }
    }
}
