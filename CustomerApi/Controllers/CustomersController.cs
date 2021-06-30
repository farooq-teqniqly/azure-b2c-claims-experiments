using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper mapper;

        public CustomersController(ICustomerRepository customerRepository, IMapper mapper)
        {
            this.customerRepository = customerRepository;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> GetCustomerInfo([FromBody] GetCustomerInfoRequestModel requestModel)
        {
            var customerInfo = await this.customerRepository.GetCustomerInfoAsync(requestModel.Email);

            if (customerInfo == null)
            {
                return this.NotFound();
            }

            var response = this.mapper.Map<CustomerInfo, GetCustomerInfoResponseModel>(customerInfo);
            return this.Ok(response);
        }
    }
}
