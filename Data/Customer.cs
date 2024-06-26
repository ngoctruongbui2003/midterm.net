﻿using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Data
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string Gender { get; set; }
        [Required]
        [MaxLength(10)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(20)]
        public string IdentityCard { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        public DateTime DateAdded { get; set; }

        // Relationship 1-n with Rent
        public ICollection<Rent> Rents { get; set; }

        public void SetCustomerByMV(CustomerMV customer) {
            Id = customer.Id;
            Name = customer.Name;
            Gender = customer.Gender;
            Phone = customer.Phone;
            IdentityCard = customer.IdentityCard;
            Address = customer.Address;
        }

        public void SetCustomerByModel(CustomerModel customer) {
            Name = customer.Name;
            Gender = customer.Gender;
            Phone = customer.Phone;
            IdentityCard = customer.IdentityCard;
            Address = customer.Address;
            DateAdded = DateTime.Now;
        }
    }
}
