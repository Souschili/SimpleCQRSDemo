using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CQRSDemo.Api.Context.Factory
{
    public class ReadDbContextFactory : IDesignTimeDbContextFactory<ReadDbContext>
    {
        public ReadDbContext CreateDbContext(string[] args)
        {
            // Загружаем конфигурацию из appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            
            var optionsBuilder = new DbContextOptionsBuilder<ReadDbContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("ReadDb"));

            return new ReadDbContext(optionsBuilder.Options);
        }
    }
}
