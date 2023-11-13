using Midterm_CarRental.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data.ViewModel
{
    public class CarMV
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string LicensePlate { get; set; }
        public string Description { get; set; }
        public string Fuel { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string DateAdded { get; set; }
        public int Status { get; set; }

        public CarMV() { }
        public CarMV(Car x)
        {
            Id = x.Id;
            Name = x.Name;
            Image = x.Image;
            LicensePlate = x.LicensePlate;
            Description = x.Description;
            Fuel = x.Fuel;
            Brand = x.Brand;
            Category = x.Category;
            DateAdded = x.DateAdded.ToString("yyyy-MM-dd HH:mm:ss");
            Status = x.Status;
        }
    }
}
