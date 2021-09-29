using Ba_DemoAPI.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ba_DemoAPI.Confixdb
{
    public class DBconnect : DbContext
    {
        public DbSet<Nhanvien> Nhanviens { get; set; }
        public DbSet<Password> Passwords { get; set; }

        public DBconnect(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Nhanvienconfig());
            modelBuilder.Seed();
        }
    }
}
