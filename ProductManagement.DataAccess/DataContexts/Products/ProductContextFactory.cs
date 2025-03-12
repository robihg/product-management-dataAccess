using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.DataAccess.DataContexts.Products
{
    public class ProductContextFactory : IDesignTimeDbContextFactory<ProductContext>
    {
        public ProductContext CreateDbContext(string[] args)
        {
            var configuration = GetConfiguration();
            var connectionString = configuration.GetConnectionString("ProductManagementDB");

            var builder = new DbContextOptionsBuilder<ProductContext>();
            builder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 32)));

            return new ProductContext(builder.Options);
        }

        private IConfigurationRoot GetConfiguration()
        {
            var basePath = Directory.GetCurrentDirectory();
            return new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }
    }
}
