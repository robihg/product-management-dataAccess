using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.DataAccess.DataContexts.GeneralSettings
{
    public class GeneralSettingContextFactory : IDesignTimeDbContextFactory<GeneralSettingContext>
    {
        public GeneralSettingContext CreateDbContext(string[] args)
        {
            var configuration = GetConfiguration();
            var connectionString = configuration.GetConnectionString("ProductManagementDB");

            var builder = new DbContextOptionsBuilder<GeneralSettingContext>();
            builder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 32)));

            return new GeneralSettingContext(builder.Options);
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
