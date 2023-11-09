using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data
{
    public class Rent
    {
        [Key]
        public int Id { get; set; }
        public DateTime DateRent { get; set; }
        public DateTime DateReturn { get; set; }
        public long PrepaidPrice { get; set; }
        
        // Realationship n-1 with Customer
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // Relationship n-1 with Car
        public int CarId { get; set; }
        public Car Car { get; set; }

        // Relationship 1-n with Rent
        public ICollection<RentDetail> RentDetails { get; set;}
    }
}
