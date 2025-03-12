using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProductManagement.DataAccess.Models.GeneralSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.DataAccess.DataContexts.GeneralSettings
{
    public class GeneralSettingContext : DbContext
    {
        public GeneralSettingContext(DbContextOptions<GeneralSettingContext> options) : base(options)
        {
        }

        public DbSet<RefUser> RefUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                var connectionString = configuration.GetConnectionString("ProductManagementDB");

                optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 32)));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
