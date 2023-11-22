﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Midterm_CarRental.Data;

#nullable disable

namespace Midterm_CarRental.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Midterm_CarRental.Data.Account", b =>
                {
                    b.Property<string>("UserName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("UserName");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            UserName = "admin",
                            DisplayName = "Admin",
                            Password = "admin123",
                            Role = 1
                        },
                        new
                        {
                            UserName = "staff1",
                            DisplayName = "Nhân viên 1",
                            Password = "staff1",
                            Role = 0
                        },
                        new
                        {
                            UserName = "staff2",
                            DisplayName = "Nhân viên 2",
                            Password = "staff2",
                            Role = 0
                        });
                });

            modelBuilder.Entity("Midterm_CarRental.Data.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Fuel")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("Midterm_CarRental.Data.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("IdentityCard")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Midterm_CarRental.Data.Feature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Features");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bản đồ",
                            Price = 100000L
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bluetooth",
                            Price = 50000L
                        },
                        new
                        {
                            Id = 3,
                            Name = "Camera lùi",
                            Price = 110000L
                        },
                        new
                        {
                            Id = 4,
                            Name = "Camera cập lề",
                            Price = 110000L
                        },
                        new
                        {
                            Id = 5,
                            Name = "Camera hành trình",
                            Price = 400000L
                        },
                        new
                        {
                            Id = 6,
                            Name = "Cảnh báo tốc độ",
                            Price = 250000L
                        },
                        new
                        {
                            Id = 7,
                            Name = "Cảm biến lốp",
                            Price = 300000L
                        },
                        new
                        {
                            Id = 8,
                            Name = "Cảm biến va chạm",
                            Price = 120000L
                        },
                        new
                        {
                            Id = 9,
                            Name = "Cửa sổ trời",
                            Price = 1000000L
                        },
                        new
                        {
                            Id = 10,
                            Name = "Định vị GPS",
                            Price = 270000L
                        },
                        new
                        {
                            Id = 11,
                            Name = "Khe cắm USB",
                            Price = 90000L
                        },
                        new
                        {
                            Id = 12,
                            Name = "Lốp dự phòng",
                            Price = 400000L
                        },
                        new
                        {
                            Id = 13,
                            Name = "Nắm thùng xe bán tải",
                            Price = 140000L
                        },
                        new
                        {
                            Id = 14,
                            Name = "Camera 360",
                            Price = 800000L
                        });
                });

            modelBuilder.Entity("Midterm_CarRental.Data.Rent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateRent")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateReturn")
                        .HasColumnType("datetime2");

                    b.Property<long>("PrepaidPrice")
                        .HasColumnType("bigint");

                    b.Property<long>("PriceCar")
                        .HasColumnType("bigint");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Rents");
                });

            modelBuilder.Entity("Midterm_CarRental.Data.RentDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("RentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FeatureId");

                    b.HasIndex("RentId");

                    b.ToTable("RentDetails");
                });

            modelBuilder.Entity("Midterm_CarRental.Data.Rent", b =>
                {
                    b.HasOne("Midterm_CarRental.Data.Car", "Car")
                        .WithMany("Rents")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Midterm_CarRental.Data.Customer", "Customer")
                        .WithMany("Rents")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Midterm_CarRental.Data.RentDetail", b =>
                {
                    b.HasOne("Midterm_CarRental.Data.Feature", "Features")
                        .WithMany("RentDetails")
                        .HasForeignKey("FeatureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Midterm_CarRental.Data.Rent", "Rent")
                        .WithMany("RentDetails")
                        .HasForeignKey("RentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Features");

                    b.Navigation("Rent");
                });

            modelBuilder.Entity("Midterm_CarRental.Data.Car", b =>
                {
                    b.Navigation("Rents");
                });

            modelBuilder.Entity("Midterm_CarRental.Data.Customer", b =>
                {
                    b.Navigation("Rents");
                });

            modelBuilder.Entity("Midterm_CarRental.Data.Feature", b =>
                {
                    b.Navigation("RentDetails");
                });

            modelBuilder.Entity("Midterm_CarRental.Data.Rent", b =>
                {
                    b.Navigation("RentDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
