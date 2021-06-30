using System;
using System.Threading.Tasks;
using CustomerApi.Models;
using CustomerApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        [HttpPost]
        public async Task<IActionResult> GetCustomerInfo([FromBody] GetCustomerInfoRequestModel requestModel)
        {
            var customerInfo = await this.customerRepository.GetCustomerInfoAsync(requestModel.CustomerId);

            if (customerInfo == null)
            {
                return this.NotFound();
            }

            return this.Ok(customerInfo);
        }
    }
}
