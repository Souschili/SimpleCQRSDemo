using CQRSDemo.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSDemo.Api.Context
{
    public class ReadDbContext:DbContext
    {
        public DbSet<Order> Orders=> Set<Order>();

        public ReadDbContext(DbContextOptions<ReadDbContext> options):base(options) { }
        

    }
}
