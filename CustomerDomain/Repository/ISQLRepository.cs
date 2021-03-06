﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerDomain.Models;

namespace CustomerDomain.Repository
{
    public interface ISQLRepository
    {
        IEnumerable<Customers> GetAllCustomers();
        Customers GetCustomerbyid(int customerid);

        Task<Customers> UpdateCustomer(Customers customer);
        Task<Customers> AddCustomer(Customers customer);
        Task<Customers> DeleteCustomer(int customerid);

    }
}
