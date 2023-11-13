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
        }
    }
}
