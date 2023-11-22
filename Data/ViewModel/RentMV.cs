using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data.ViewModel
{
    public class RentMV
    {
        public int IdRent { get; set; }
        public DateTime DateRent { get; set; }
        public DateTime DateReturn { get; set; }
        public long PriceCar { get; set; }
        public long PrepaidPrice { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerIdentityCard { get; set; }
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarLicensePlate { get; set; }
        public long CarPrice { get; set; }
        public string CarStatus { get; set; }
        public List<FeatureMV> Features { get; set; }
        public ICollection<RentDetail> RentDetails { get; set; }

        public RentMV() { }
        public void SetRentMVByRent(Rent rent)
        {
            IdRent = rent.Id;
            DateRent = rent.DateRent;
            DateReturn = rent.DateReturn;
            PriceCar = rent.PriceCar;
            PrepaidPrice = rent.PrepaidPrice;
            Status = rent.Status;
            CustomerId = rent.CustomerId;
            CustomerName = rent.Customer.Name;
            CustomerPhone = rent.Customer.Phone;
            CustomerIdentityCard = rent.Customer.IdentityCard;
            CarId = rent.CarId;
            CarName = rent.Car.Name;
            CarLicensePlate = rent.Car.LicensePlate;
            CarPrice = rent.Car.Price;
            RentDetails = rent.RentDetails;
        }
    }
}
