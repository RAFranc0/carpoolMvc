using System;
using carpoolmvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pomelo.EntityFrameworkCore.MySql.Extensions;

namespace carpoolmvc.Data
{
    public class carpoolMvcDb : DbContext
    {
        public carpoolMvcDb(DbContextOptions<carpoolMvcDb> options)
            : base(options) { }

        //public DbSet<classe> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"));
            }
        }
    }
}
