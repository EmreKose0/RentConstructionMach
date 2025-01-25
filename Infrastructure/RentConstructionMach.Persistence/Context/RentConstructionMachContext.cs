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
            optionsBuilder.UseMySql("server=localhost;port=3306;uid=emrek;pwd=1234;Database=rentconstructionmachinedb;",
              new MySqlServerVersion(new Version(9, 0, 0)),
              options => options.EnableRetryOnFailure());
            //optionsBuilder.UseSqlServer(
            //    "Server=localhost;Database=rentconstructionmachinedb;Trusted_Connection=True;TrustServerCertificate=True;",
            //    options => options.EnableRetryOnFailure()
            //   );
        }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<MachCategory> MachCategories { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<MachineRequest> MachineRequests { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<AddService> AddServices { get; set; }
        public DbSet<MachinePricing> MachinePricings { get; set; }
        public DbSet<MachineService> MachineServices { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<MachineLocation> MachineLocations { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }

        
    }
}
