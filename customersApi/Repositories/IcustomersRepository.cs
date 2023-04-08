using customersApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customersApi.Repositories
{
    public interface IcustomersRepository
    {
        Task<IEnumerable<customers>> GetAllCustomers();
        Task<bool> InsertCustomer(customers customer); 

    }
}
