using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }    
        public long Price { get; set; }

        // Relationship 1-n with Rent
        public ICollection<RentDetail> RentDetails { get; set; }
    }
}
