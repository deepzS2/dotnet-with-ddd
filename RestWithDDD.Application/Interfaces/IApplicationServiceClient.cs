using RestWithDDD.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWithDDD.Application.Interfaces
{
    public interface IApplicationServiceClient
    {
        Task<IEnumerable<ClientDTO>> GetAll();
        Task<ClientDTO> GetById(int id);
        Task Add(ClientDTO dto);
        Task Update(ClientDTO dto);
        Task Delete(ClientDTO dto);
    }
}
