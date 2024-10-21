using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CQRSDemo.Api.Context.Factory
{
    public class WriteDbContextFactory : IDesignTimeDbContextFactory<WriteDbContext>
    {
        public WriteDbContext CreateDbContext(string[] args)
        {
            var config= new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<WriteDbContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("WriteDb"));
            return new WriteDbContext(optionsBuilder.Options);
        }
    }
}
