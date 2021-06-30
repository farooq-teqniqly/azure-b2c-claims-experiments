using System;
using System.Threading.Tasks;
using CustomerApi.Models;

namespace CustomerApi.Repositories
{
    public interface ICustomerRepository
    {
        Task<CustomerInfo> GetCustomerInfoAsync(string email);
    }
}