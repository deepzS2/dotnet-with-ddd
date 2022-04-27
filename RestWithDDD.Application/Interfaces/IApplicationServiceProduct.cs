using RestWithDDD.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWithDDD.Application.Interfaces
{
    public interface IApplicationServiceProduct
    {
        Task<IEnumerable<ProductDTO>> GetAll();
        Task<ProductDTO> GetById(int id);
        Task Add(ProductDTO client);
        Task Update(ProductDTO client);
        Task Delete(ProductDTO client);
    }
}
