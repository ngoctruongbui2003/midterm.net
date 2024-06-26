﻿using Midterm_CarRental.Data.Model;
using Midterm_CarRental.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_CarRental.Repositories
{
    public interface ICustomerRepository : IRepository<CustomerModel, CustomerMV>
    {
        List<CustomerMV> GetByName(string name);
        List<CustomerMV> GetByPhone(string name);
        List<CustomerMV> GetByIdentityCard(string name);
        
    }
}
