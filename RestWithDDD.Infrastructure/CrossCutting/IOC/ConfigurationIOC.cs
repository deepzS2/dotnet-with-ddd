using Autofac;
using RestWithDDD.Application;
using RestWithDDD.Application.Interfaces;
using RestWithDDD.Domain.Services;
using RestWithDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestWithDDD.Infrastructure.Data.Repositories;
using RestWithDDD.Domain.Core.Interfaces.Repositories;
using RestWithDDD.Application.Mappers;
using RestWithDDD.Application.Mappers.Interfaces;

namespace RestWithDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
            builder.RegisterType<ApplicationServiceClient>().As<IApplicationServiceClient>();
            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            builder.RegisterType<ServiceClient>().As<IServiceClient>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<RepositoryClient>().As<IRepositoryClient>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<ServiceClient>().As<IServiceClient>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<MapperClient>().As<IMapperClient>();
            builder.RegisterType<MapperProduct>().As<IMapperProduct>();
            #endregion
        }
    }
}
