﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using intro_ef.Data;

#nullable disable

namespace intro_ef.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240909124644_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("intro_ef.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CreaditCardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Sales")
                        .HasColumnType("float");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("intro_ef.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("Sales")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("intro_ef.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SaleId"));

                    b.Property<string>("Customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Store")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SaleId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("intro_ef.Models.Store", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"));

                    b.Property<double>("Sales")
                        .HasColumnType("float");

                    b.Property<string>("StoreName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoreId");

                    b.ToTable("Stores");
                });
#pragma warning restore 612, 618
        }
    }
}
