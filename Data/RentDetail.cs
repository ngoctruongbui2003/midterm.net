using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data
{
    public class RentDetail
    {
        [Key]
        public int Id { get; set; }
        public long Price { get; set; }

        // Relationship n-1 with Rent
        public int RentId { get; set; }
        public Rent Rent { get; set; }

        // Relationship n-1 with Feature
        public int FeatureId { get; set; }
        public Feature Features { get; set; }
    }
}
