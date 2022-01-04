using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace eShopsolution.Data.EF
{
    public class eShopsolutionDbContextFactory : IDesignTimeDbContextFactory<eShopDbContext>
    {
        public eShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();


            var optionBuilder = new DbContextOptionsBuilder<eShopDbContext>();
            optionBuilder.UseSqlServer();
             return new eShopDbContext(optionBuilder.Options);
        }
    }
}
