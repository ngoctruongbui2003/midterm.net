using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data.Model
{
    public class CarModel
    {
        public string Name { get; set; }
        public string LicensePlate { get; set; }
        public long Price { get; set; }
        public string Description { get; set; }
        public string Fuel { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
    }
}
