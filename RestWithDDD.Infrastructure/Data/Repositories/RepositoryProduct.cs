using RestWithDDD.Domain.Core.Interfaces.Repositories;
using RestWithDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWithDDD.Infrastructure.Data.Repositories
{
    public class RepositoryProduct : RepositoryBase<Product>, IRepositoryProduct
    {
        private readonly InfraContext _databaseContext;

        public RepositoryProduct(InfraContext databaseContext) : base(databaseContext)
        {
            _databaseContext = databaseContext;
        }
    }
}
