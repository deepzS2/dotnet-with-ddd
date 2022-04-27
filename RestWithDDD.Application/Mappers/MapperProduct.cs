using RestWithDDD.Application.DTOs;
using RestWithDDD.Domain.Entities;
using RestWithDDD.Application.Mappers.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RestWithDDD.Application.Mappers
{
    public class MapperProduct : IMapperProduct
    {
        public IEnumerable<ProductDTO> MapperEntityListToDto(IEnumerable<Product> products)
        {
            return products.Select(p => new ProductDTO { Id = p.Id, Name = p.Name, Price = p.Price });
        }

        public Product MapperDtoToEntity(ProductDTO dto)
        {
            var Product = new Product()
            {
                Id = dto.Id.Value,
                Name = dto.Name,
                Price = dto.Price
            };

            return Product;
        }

        public ProductDTO MapperEntityToDto(Product product)
        {
            var dto = new ProductDTO()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };

            return dto;
        }
    }
}