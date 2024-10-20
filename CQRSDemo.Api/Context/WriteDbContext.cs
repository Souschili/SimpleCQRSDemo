using CQRSDemo.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSDemo.Api.Context
{
    public class WriteDbContext:DbContext
    {
        public DbSet<Order> Orders => Set<Order>();

        public WriteDbContext(DbContextOptions<WriteDbContext> options):base(options) { }

    }
}
