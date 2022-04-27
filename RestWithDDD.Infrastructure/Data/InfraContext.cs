using Microsoft.EntityFrameworkCore;
using RestWithDDD.Domain.Entities;

namespace RestWithDDD.Infrastructure.Data
{
    public class InfraContext : DbContext
    {
        public InfraContext() { }

        public InfraContext(DbContextOptions<InfraContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
