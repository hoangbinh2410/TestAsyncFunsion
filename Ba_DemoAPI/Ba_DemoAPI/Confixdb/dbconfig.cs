using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Ba_DemoAPI.Confixdb
{
    public class dbconfig : IDesignTimeDbContextFactory<DBconnect>
    {
        public DBconnect CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();
            var connectionString = configuration.GetConnectionString("UserDatabase");
            var optionsBuilder = new DbContextOptionsBuilder<DBconnect>();
            optionsBuilder.UseSqlServer(connectionString);
            return new DBconnect(optionsBuilder.Options);
        }
    }
}
