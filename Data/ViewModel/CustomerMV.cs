using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data.ViewModel
{
    public class CustomerMV
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string IdentityCard { get; set; }
        public string Address { get; set; }
        public string DateAdded { get; set; }

        public CustomerMV() { }
        public void SetCustomerMVByCustomer(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            Gender = customer.Gender;
            Phone = customer.Phone;
            IdentityCard = customer.IdentityCard;
            Address = customer.Address;
            DateAdded = customer.DateAdded.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
