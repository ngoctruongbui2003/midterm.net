using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data.Model
{
    public class RentModel
    {
        public DateTime DateRent { get; set; }
        public DateTime DateReturn { get; set; }
        public long PriceCar { get; set; }
        public long PrepaidPrice { get; set; }
        public int CustomerId { get; set; }
        public int CarId { get; set; }
        public string Status { get; set; }
    }
}
