using Midterm_CarRental.Data;
using Midterm_CarRental.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MyDbContext _context;

        public CustomerRepository(MyDbContext context) {
            _context = context;
        }
        public bool Add(CustomerModel customer)
        {
            try
            {
                _context.Add(new Customer
                {
                    Name = customer.Name,
                    Gender = customer.Gender,
                    Phone = customer.Phone,
                    IdentityCard = customer.IdentityCard,
                    Address = customer.Address,
                    DateAdded = DateTime.Now
                });
                _context.SaveChanges();

                return true;
            } catch
            {
                throw new Exception("No add customer successfully");
            }
        }

        public List<CustomerMV> GetAll()
        {
            try
            {
                List<Customer> customers = _context.Customers.ToList();

                return customers.Select(x => new CustomerMV
                {
                    Id = x.Id,
                    Name = x.Name,
                    Gender = x.Gender,
                    Phone = x.Phone,
                    IdentityCard = x.IdentityCard,
                    Address = x.Address,
                    DateAdded = x.DateAdded.ToString("yyyy-MM-dd HH:mm:ss")
                }).ToList();
            } catch
            {
                throw new Exception("Get all customer not successfully!");
            }
        }

        public CustomerMV GetById(int id)
        {
            throw new NotImplementedException();
        }



        public List<CustomerMV> GetByName(string name)
        {
            try
            {
                List<Customer> customer = _context.Customers.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();

                return customer.Select(x => new CustomerMV
                {
                    Id = x.Id,
                    Name = x.Name,
                    Gender = x.Gender,
                    Phone = x.Phone,
                    IdentityCard = x.IdentityCard,
                    Address = x.Address,
                    DateAdded = x.DateAdded.ToString("yyyy-MM-dd HH:mm:ss")
                }).ToList();
            }
            catch
            {
                throw new Exception("Get by name customer not successfully!");
            }
        }

        public bool Update(CustomerModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
