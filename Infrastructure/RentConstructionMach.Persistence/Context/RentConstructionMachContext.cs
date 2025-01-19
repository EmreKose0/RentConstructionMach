using Microsoft.EntityFrameworkCore;
using RentConstructionMach.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentConstructionMach.Persistence.Context
{
    public class RentConstructionMachContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=45.143.99.46;port=3306;uid=Saber;pwd=Saber*Emre02;Database=rentconstructionmachinedb;",
              new MySqlServerVersion(new Version(9, 0, 0)),
              options => options.EnableRetryOnFailure());
        }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
    }
}
