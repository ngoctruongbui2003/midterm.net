using Microsoft.IdentityModel.Tokens;
using Midterm_CarRental.Data;
using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories.Impl
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MyDbContext _context;

        public CustomerRepository(MyDbContext context)
        {
            _context = context;
        }
        public int Add(CustomerModel customer)
        {
            try
            {
                Customer customerNew = new Customer();
                customerNew.SetCustomerByModel(customer);
                _context.Add(customerNew);
                _context.SaveChanges();

                return customerNew.Id;
            }
            catch
            {
                return -1;
            }
        }

        public List<CustomerMV> GetAll(bool isDesc)
        {
            try
            {
                List<Customer> customers = _context.Customers.ToList();

                var res = customers.Select(x =>
                {
                    CustomerMV customer = new CustomerMV();
                    customer.SetCustomerMVByCustomer(x);
                    return customer;
                }).ToList();

                if (isDesc)
                {
                    res.Reverse();
                }

                return res;
            }
            catch
            {
                throw new Exception("Get all customers not successfully!");
            }
        }

        public CustomerMV GetById(int id)
        {
            try
            {
                var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

                if (customer == null) return null;

                CustomerMV res = new CustomerMV();
                res.SetCustomerMVByCustomer(customer);

                return res;
            }
            catch
            {
                throw new Exception("Get by id customer not successfully!");
            }
        }



        public List<CustomerMV> GetByName(string name)
        {
            try
            {
                List<Customer> customers = _context.Customers.ToList();

                var res = customers.Where(customer =>
                            customer.Name.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0)
                            .Select(x =>
                            {
                                CustomerMV customerMV = new CustomerMV();
                                customerMV.SetCustomerMVByCustomer(x);
                                return customerMV;
                            }).ToList();
                return res;
            }
            catch
            {
                throw new Exception("Get customer by name not successfully!");
            }
        }

        public List<CustomerMV> GetByPhone(string namePhone)
        {
            try
            {
                List<Customer> customers = _context.Customers.ToList();

                if (!namePhone.Trim().IsNullOrEmpty())
                {
                    return customers.Where(customer => customer.Phone.Contains(namePhone))
                            .Select(x =>
                            {
                                CustomerMV customerMV = new CustomerMV();
                                customerMV.SetCustomerMVByCustomer(x);
                                return customerMV;
                            }).ToList();
                }

                return null;
            }
            catch
            {
                throw new Exception("Get customer by phone not successfully!");
            }
        }

        public List<CustomerMV> GetByIdentityCard(string identityCard)
        {
            try
            {
                List<Customer> customers = _context.Customers.ToList();

                if (!identityCard.Trim().IsNullOrEmpty())
                {
                    return customers.Where(customer => customer.IdentityCard.Contains(identityCard))
                            .Select(x =>
                            {
                                CustomerMV customerMV = new CustomerMV();
                                customerMV.SetCustomerMVByCustomer(x);
                                return customerMV;
                            }).ToList();
                }

                return null;
            }
            catch
            {
                throw new Exception("Get customer by identity caard not successfully!");
            }
        }
        public void Update(CustomerMV model)
        {
            try
            {
                var customer = _context.Customers.SingleOrDefault(c => c.Id == model.Id);

                if (customer == null) return;

                customer.SetCustomerByMV(model);
                customer.DateAdded = DateTime.Now;

                _context.SaveChanges();

            }
            catch
            {
                throw new Exception("Update customer not successfully!");
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

                if (customer == null)
                {
                    return false;
                }
                _context.Remove(customer);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}
