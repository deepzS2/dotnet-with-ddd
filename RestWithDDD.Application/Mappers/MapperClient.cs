using RestWithDDD.Application.DTOs;
using RestWithDDD.Domain.Entities;
using RestWithDDD.Application.Mappers.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RestWithDDD.Application.Mappers
{
    public class MapperClient : IMapperClient
    {
        public IEnumerable<ClientDTO> MapperEntityListToDto(IEnumerable<Client> clients)
        {
            return clients.Select(c => new ClientDTO { Id = c.Id, Name = c.Name, LastName = c.LastName, Email = c.Email });
        }

        public Client MapperDtoToEntity(ClientDTO dto)
        {
            var client = new Client()
            {
                Id = dto.Id.Value,
                Name = dto.Name,
                LastName = dto.LastName,
                Email = dto.Email,
            };

            return client;
    }

        public ClientDTO MapperEntityToDto(Client client)
        {
            var dto = new ClientDTO()
            {
                Id = client.Id,
                Name = client.Name,
                LastName = client.LastName,
                Email = client.Email,
            };

            return dto;
        }
    }
}
