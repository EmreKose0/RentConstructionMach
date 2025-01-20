﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentConstructionMach.Persistence.Context;

#nullable disable

namespace RentConstructionMach.Persistence.Migrations
{
    [DbContext(typeof(RentConstructionMachContext))]
    [Migration("20250120104611_status2")]
    partial class status2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.AddService", b =>
                {
                    b.Property<int>("AddServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("AddServiceID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AddServiceID");

                    b.ToTable("AddServices");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("BlogID"));

                    b.Property<string>("CoverImgUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BlogID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.Brand", b =>
                {
                    b.Property<int>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("BrandID"));

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BrandID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerSurname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.FooterAddress", b =>
                {
                    b.Property<int>("FooterAddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("FooterAddressID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("FooterAddressID");

                    b.ToTable("FooterAddresses");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("LocationID"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("LocationID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.MachCategory", b =>
                {
                    b.Property<int>("MachCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MachCategoryID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("MachCategoryID");

                    b.ToTable("MachCategories");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.Machine", b =>
                {
                    b.Property<int>("MachineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MachineID"));

                    b.Property<bool>("AvailabilityStatus")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("BigImgUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("BrandID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MachCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("ProductionYear")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("StandartImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TransportCapacity")
                        .HasColumnType("int");

                    b.Property<int>("WorkingHours")
                        .HasColumnType("int");

                    b.Property<int>("WorkingWeight")
                        .HasColumnType("int");

                    b.HasKey("MachineID");

                    b.HasIndex("BrandID");

                    b.HasIndex("MachCategoryID");

                    b.ToTable("Machines");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.MachineLocation", b =>
                {
                    b.Property<int>("MachineLocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MachineLocationID"));

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<int>("MachineID")
                        .HasColumnType("int");

                    b.HasKey("MachineLocationID");

                    b.HasIndex("LocationID");

                    b.HasIndex("MachineID");

                    b.ToTable("MachineLocations");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.MachinePricing", b =>
                {
                    b.Property<int>("MachinePricingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MachinePricingID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("MachineID")
                        .HasColumnType("int");

                    b.Property<int>("PricingID")
                        .HasColumnType("int");

                    b.HasKey("MachinePricingID");

                    b.HasIndex("MachineID");

                    b.HasIndex("PricingID");

                    b.ToTable("MachinePricings");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.MachineRequest", b =>
                {
                    b.Property<int>("MachineRequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MachineRequestID"));

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CustomerSurname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<int>("MachineID")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal?>("TotalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("MachineRequestID");

                    b.HasIndex("LocationID");

                    b.HasIndex("MachineID");

                    b.ToTable("MachineRequests");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.MachineService", b =>
                {
                    b.Property<int>("MachineServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("MachineServiceID"));

                    b.Property<int>("AddServiceID")
                        .HasColumnType("int");

                    b.Property<bool>("Available")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("MachineID")
                        .HasColumnType("int");

                    b.HasKey("MachineServiceID");

                    b.HasIndex("AddServiceID");

                    b.HasIndex("MachineID");

                    b.ToTable("MachineServices");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.Pricing", b =>
                {
                    b.Property<int>("PricingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PricingID"));

                    b.Property<string>("PricingName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("PricingID");

                    b.ToTable("Pricings");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.TagCloud", b =>
                {
                    b.Property<int>("TagCloudID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("TagCloudID"));

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TagCloudID");

                    b.HasIndex("BlogID");

                    b.ToTable("TagClouds");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.Machine", b =>
                {
                    b.HasOne("RentConstructionMach.Domain.Entities.Brand", "Brand")
                        .WithMany("Machines")
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentConstructionMach.Domain.Entities.MachCategory", "MachCategory")
                        .WithMany("Machines")
                        .HasForeignKey("MachCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");

                    b.Navigation("MachCategory");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.MachineLocation", b =>
                {
                    b.HasOne("RentConstructionMach.Domain.Entities.Location", "Location")
                        .WithMany("MachineLocations")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentConstructionMach.Domain.Entities.Machine", "Machine")
                        .WithMany("MachineLocations")
                        .HasForeignKey("MachineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Machine");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.MachinePricing", b =>
                {
                    b.HasOne("RentConstructionMach.Domain.Entities.Machine", "Machine")
                        .WithMany("MachinePricing")
                        .HasForeignKey("MachineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentConstructionMach.Domain.Entities.Pricing", "Pricing")
                        .WithMany("MachinePricing")
                        .HasForeignKey("PricingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Machine");

                    b.Navigation("Pricing");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.MachineRequest", b =>
                {
                    b.HasOne("RentConstructionMach.Domain.Entities.Location", "Location")
                        .WithMany("MachineRequests")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentConstructionMach.Domain.Entities.Machine", "Machine")
                        .WithMany("MachineRequest")
                        .HasForeignKey("MachineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Machine");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.MachineService", b =>
                {
                    b.HasOne("RentConstructionMach.Domain.Entities.AddService", "AddService")
                        .WithMany("MachineServices")
                        .HasForeignKey("AddServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RentConstructionMach.Domain.Entities.Machine", "Machine")
                        .WithMany("MachineServices")
                        .HasForeignKey("MachineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddService");

                    b.Navigation("Machine");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.TagCloud", b =>
                {
                    b.HasOne("RentConstructionMach.Domain.Entities.Blog", "Blog")
                        .WithMany("TagClouds")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.AddService", b =>
                {
                    b.Navigation("MachineServices");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.Blog", b =>
                {
                    b.Navigation("TagClouds");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.Brand", b =>
                {
                    b.Navigation("Machines");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.Location", b =>
                {
                    b.Navigation("MachineLocations");

                    b.Navigation("MachineRequests");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.MachCategory", b =>
                {
                    b.Navigation("Machines");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.Machine", b =>
                {
                    b.Navigation("MachineLocations");

                    b.Navigation("MachinePricing");

                    b.Navigation("MachineRequest");

                    b.Navigation("MachineServices");
                });

            modelBuilder.Entity("RentConstructionMach.Domain.Entities.Pricing", b =>
                {
                    b.Navigation("MachinePricing");
                });
#pragma warning restore 612, 618
        }
    }
}
