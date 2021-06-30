using System;
using System.Threading.Tasks;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerInfo(Guid id)
        {
            var customerInfo = await this.customerRepository.GetCustomerInfoAsync(id);

            if (customerInfo == null)
            {
                return this.NotFound();
            }

            return this.Ok(customerInfo);
        }
    }
}
