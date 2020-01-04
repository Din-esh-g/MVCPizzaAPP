﻿using ChajdPizzaWebApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChajdPizzaWebApp.Repositories.Interfaces
{
    public interface ICustomerRepo
    {
        public Task<Customer> SelectById(int? id);

        public Task<Customer> SelectByUser(string Username);

        public Task<List<Customer>> SelectAll();

        public Task<bool> Add(Customer customer);

        public Task<bool> Put(Customer customer);

        public Task<bool> Update(Customer customer);

        public Task<bool> Remove(Customer customer);

        public bool CustomerExists(int id);
    }
}
