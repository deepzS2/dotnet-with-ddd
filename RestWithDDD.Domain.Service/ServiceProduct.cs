using RestWithDDD.Domain.Core.Interfaces.Repositories;
using RestWithDDD.Domain.Core.Interfaces.Services;
using RestWithDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWithDDD.Domain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct _repository;

        public ServiceProduct(IRepositoryProduct repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
