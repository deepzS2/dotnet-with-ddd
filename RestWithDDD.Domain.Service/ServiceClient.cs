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
    public class ServiceClient : ServiceBase<Client>, IServiceClient
    {
        private readonly IRepositoryClient _repository;

        public ServiceClient(IRepositoryClient repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
