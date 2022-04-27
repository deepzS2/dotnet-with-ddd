using RestWithDDD.Application.DTOs;
using RestWithDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWithDDD.Application.Mappers.Interfaces
{
    public interface IMapperProduct
    {
        Product MapperDtoToEntity(ProductDTO dto);
        IEnumerable<ProductDTO> MapperEntityListToDto(IEnumerable<Product> products);
        ProductDTO MapperEntityToDto(Product Product);
    }
}