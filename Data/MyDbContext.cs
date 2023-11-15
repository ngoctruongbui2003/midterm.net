using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ConString"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(
                    new Account
                    {
                        UserName = "admin",
                        Password = "admin123",
                        DisplayName = "Admin",
                        Role = 1
                    },
                    new Account
                    {
                        UserName = "staff1",
                        Password = "staff1",
                        DisplayName = "Nhân viên 1",
                        Role = 0
                    },
                    new Account
                    {
                        UserName = "staff2",
                        Password = "staff2",
                        DisplayName = "Nhân viên 2",
                        Role = 0
                    }
                );
            modelBuilder.Entity<Feature>().HasData(
                    new Feature
                    {
                        Name = "Bản đồ",
                        Price = 100000,
                    },
                    new Feature
                    {
                        Name = "Bluetooth",
                        Price = 50000,
                    },
                    new Feature
                    {
                        Name = "Camera lùi",
                        Price = 110000,
                    },
                    new Feature
                    {
                        Name = "Camera cập lề",
                        Price = 110000,
                    },
                    new Feature
                    {
                        Name = "Camera hành trình",
                        Price = 400000,
                    },
                    new Feature
                    {
                        Name = "Cảnh báo tốc độ",
                        Price = 250000,
                    },
                    new Feature
                    {
                        Name = "Cảm biến lốp",
                        Price = 300000,
                    },
                    new Feature
                    {
                        Name = "Cảm biến va chạm",
                        Price = 120000,
                    },
                    new Feature
                    {
                        Name = "Cửa sổ trời",
                        Price = 1000000,
                    },
                    new Feature
                    {
                        Name = "Định vị GPS",
                        Price = 270000,
                    },
                    new Feature
                    {
                        Name = "Khe cắm USB",
                        Price = 90000,
                    },
                    new Feature
                    {
                        Name = "Lốp dự phòng",
                        Price = 400000,
                    },
                    new Feature
                    {
                        Name = "Nắm thùng xe bán tải",
                        Price = 140000,
                    },
                    new Feature
                    {
                        Name = "Camera 360",
                        Price = 800000,
                    }
                );
        }
    }
}
