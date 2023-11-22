using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Data.ViewModel;
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
        public long PriceCar { get; set; }
        public long PrepaidPrice { get; set; }
        public string Status { get; set; }

        // Realationship n-1 with Customer
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // Relationship n-1 with Car
        public int CarId { get; set; }
        public Car Car { get; set; }

        // Relationship 1-n with Rent
        public ICollection<RentDetail> RentDetails { get; set;}

        public void SetRentByModel(RentModel rentModel)
        {
            DateRent = rentModel.DateRent;
            DateReturn = rentModel.DateReturn;
            PrepaidPrice = rentModel.PrepaidPrice;
            PriceCar = rentModel.PriceCar;
            Status = rentModel.Status;
            CustomerId = rentModel.CustomerId;
            CarId = rentModel.CarId;
        }

        public long GetRemainingPrice()
        {
            return this.GetTotalPrice() - PrepaidPrice;
        }

        public long GetTotalPrice()
        {
            long total = 0;

            foreach (var item in RentDetails)
            {
                total += item.Price;
            }
            DateTime pickupdate = Convert.ToDateTime(DateRent.Date);
            DateTime dropoffdate = Convert.ToDateTime(DateReturn.Date);
            TimeSpan span = dropoffdate.Subtract(pickupdate);
            int dayTotal = Convert.ToInt32(Math.Round(span.TotalDays));
            total += dayTotal * PriceCar;

            return total;
        }
    }
}
