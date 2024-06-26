﻿using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [MaxLength(10)]
        public string LicensePlate { get; set; }
        [Required]
        public long Price { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [MaxLength(20)]
        public string Fuel { get; set; }
        [MaxLength(20)]
        public string Brand { get; set; }
        [MaxLength(20)]
        public string Category { get; set; }
        public DateTime DateAdded { get; set; }
        public string Status { get; set; }

        // Relationship 1-n with Rent
        public ICollection<Rent> Rents { get; set; }

        public Car() { }

        public void SetCarByMV(CarMV model)
        {
            Id = model.Id;
            Name = model.Name;
            LicensePlate = model.LicensePlate;
            Price = model.Price;
            Description = model.Description;
            Fuel = model.Fuel;
            Brand = model.Brand;
            Category = model.Category;
        }

        public void SetCarByModel(CarModel model)
        {
            Name = model.Name;
            LicensePlate = model.LicensePlate;
            Price = model.Price;
            Description = model.Description;
            Fuel = model.Fuel;
            Brand = model.Brand;
            Category = model.Category;
            Status = model.Status;
            DateAdded = DateTime.Now;
        }
    }
}
