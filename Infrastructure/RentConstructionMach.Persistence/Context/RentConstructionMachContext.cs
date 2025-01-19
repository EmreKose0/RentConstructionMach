﻿using Microsoft.EntityFrameworkCore;
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

    }
}
