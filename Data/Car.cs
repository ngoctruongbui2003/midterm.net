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
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Image { get; set; }
        [Required]
        [MaxLength(10)]
        public string LicensePlate { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [MaxLength(20)]
        public string Fuel { get; set; }
        [MaxLength(20)]
        public string Brand { get; set; }
        [MaxLength(20)]
        public string Category { get; set; }
        public DateTime DateAdded { get; set; }
        public int Status { get; set; }

        // Relationship 1-n with Rent
        public ICollection<Rent> Rents { get; set; }
    }
}
