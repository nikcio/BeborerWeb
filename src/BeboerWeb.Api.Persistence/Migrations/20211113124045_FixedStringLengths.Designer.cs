﻿// <auto-generated />
using System;
using BeboerWeb.Api.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeboerWeb.Api.Persistence.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20211113124045_FixedStringLengths")]
    partial class FixedStringLengths
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AddressProperty", b =>
                {
                    b.Property<int>("AddressesId")
                        .HasColumnType("int");

                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.HasKey("AddressesId", "PropertiesId");

                    b.HasIndex("PropertiesId");

                    b.ToTable("AddressProperty");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Address", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(85)
                        .HasColumnType("nvarchar(85)");

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(56)
                        .HasColumnType("nvarchar(56)");

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Lesse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Apartment")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Story")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lesses");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.LessePeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LesseId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LesseId");

                    b.ToTable("LessePeriods");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Tenants");
                });

            modelBuilder.Entity("CompanyEmployee", b =>
                {
                    b.Property<int>("CompaniesId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.HasKey("CompaniesId", "EmployeesId");

                    b.HasIndex("EmployeesId");

                    b.ToTable("CompanyEmployee");
                });

            modelBuilder.Entity("CompanyEmployee1", b =>
                {
                    b.Property<int>("OwnedCompaniesId")
                        .HasColumnType("int");

                    b.Property<int>("OwnersId")
                        .HasColumnType("int");

                    b.HasKey("OwnedCompaniesId", "OwnersId");

                    b.HasIndex("OwnersId");

                    b.ToTable("CompanyEmployee1");
                });

            modelBuilder.Entity("CompanyProperty", b =>
                {
                    b.Property<int>("CompaniesId")
                        .HasColumnType("int");

                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.HasKey("CompaniesId", "PropertiesId");

                    b.HasIndex("PropertiesId");

                    b.ToTable("CompanyProperty");
                });

            modelBuilder.Entity("LessePeriodTenant", b =>
                {
                    b.Property<int>("LessePeriodsId")
                        .HasColumnType("int");

                    b.Property<int>("TenantsId")
                        .HasColumnType("int");

                    b.HasKey("LessePeriodsId", "TenantsId");

                    b.HasIndex("TenantsId");

                    b.ToTable("LessePeriodTenant");
                });

            modelBuilder.Entity("LesseProperty", b =>
                {
                    b.Property<int>("LessesId")
                        .HasColumnType("int");

                    b.Property<int>("PropertiesId")
                        .HasColumnType("int");

                    b.HasKey("LessesId", "PropertiesId");

                    b.HasIndex("PropertiesId");

                    b.ToTable("LesseProperty");
                });

            modelBuilder.Entity("AddressProperty", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Address", null)
                        .WithMany()
                        .HasForeignKey("AddressesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Address", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.City", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Employee", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Person", "Person")
                        .WithMany("Employees")
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.LessePeriod", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Lesse", "Lesse")
                        .WithMany("LessePeriods")
                        .HasForeignKey("LesseId");

                    b.Navigation("Lesse");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Tenant", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Person", "Person")
                        .WithMany("Tenants")
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("CompanyEmployee", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Company", null)
                        .WithMany()
                        .HasForeignKey("CompaniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyEmployee1", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Company", null)
                        .WithMany()
                        .HasForeignKey("OwnedCompaniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Employee", null)
                        .WithMany()
                        .HasForeignKey("OwnersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyProperty", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Company", null)
                        .WithMany()
                        .HasForeignKey("CompaniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LessePeriodTenant", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.LessePeriod", null)
                        .WithMany()
                        .HasForeignKey("LessePeriodsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Tenant", null)
                        .WithMany()
                        .HasForeignKey("TenantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LesseProperty", b =>
                {
                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Lesse", null)
                        .WithMany()
                        .HasForeignKey("LessesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeboerWeb.Api.Domain.Models.PropertyManangement.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.City", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Lesse", b =>
                {
                    b.Navigation("LessePeriods");
                });

            modelBuilder.Entity("BeboerWeb.Api.Domain.Models.PropertyManangement.Person", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Tenants");
                });
#pragma warning restore 612, 618
        }
    }
}
