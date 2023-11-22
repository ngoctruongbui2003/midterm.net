using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data.Model
{
    public class RentDetailModel
    {
        public long Price { get; set; }

        // Relationship n-1 with Rent
        public int RentId { get; set; }

        // Relationship n-1 with Feature
        public int FeatureId { get; set; }
    }
}
