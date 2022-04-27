using RestWithDDD.Application.DTOs;
using RestWithDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWithDDD.Application.Mappers.Interfaces
{
    public interface IMapperClient
    {
        Client MapperDtoToEntity(ClientDTO dto);
        IEnumerable<ClientDTO> MapperEntityListToDto(IEnumerable<Client> clients);
        ClientDTO MapperEntityToDto(Client client);
    }
}
