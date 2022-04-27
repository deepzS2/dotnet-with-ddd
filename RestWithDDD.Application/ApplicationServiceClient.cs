using RestWithDDD.Application.DTOs;
using RestWithDDD.Application.Interfaces;
using RestWithDDD.Application.Mappers.Interfaces;
using RestWithDDD.Domain.Core.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestWithDDD.Application
{
    public class ApplicationServiceClient : IApplicationServiceClient
    {
        private readonly IServiceClient _service;
        private readonly IMapperClient _mapper;

        public ApplicationServiceClient(IServiceClient service, IMapperClient mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task Add(ClientDTO dto)
        {
            var client = _mapper.MapperDtoToEntity(dto);
            await _service.Add(client);
        }

        public async Task Delete(ClientDTO dto)
        {
            var client = _mapper.MapperDtoToEntity(dto);
            await _service.Delete(client);
        }

        public async Task<IEnumerable<ClientDTO>> GetAll()
        {
            var clients = await _service.GetAll();
            return _mapper.MapperEntityListToDto(clients);
        }

        public async Task<ClientDTO> GetById(int id)
        {
            var client = await _service.GetById(id);
            return _mapper.MapperEntityToDto(client);
        }

        public async Task Update(ClientDTO dto)
        {
            var client = _mapper.MapperDtoToEntity(dto);
            await _service.Update(client);
        }
    }
}
