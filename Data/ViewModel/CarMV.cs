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
        public string LicensePlate { get; set; }
        public string Description { get; set; }
        public string Fuel { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string DateAdded { get; set; }
        public int Status { get; set; }

        public CarMV() { }

        public void SetCarMVByCar(Car car)
        {
            Id = car.Id;
            Name = car.Name;
            LicensePlate = car.LicensePlate;
            Description = car.Description;
            Fuel = car.Fuel;
            Brand = car.Brand;
            Category = car.Category;
            DateAdded = car.DateAdded.ToString("yyyy-MM-dd HH:mm:ss");
            Status = car.Status;
        }
    }
}
