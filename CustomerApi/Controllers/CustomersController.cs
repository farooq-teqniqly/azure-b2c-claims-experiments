using System;
using System.Collections.Generic;
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
            var customerInfo = await this.customerRepository.GetCustomerInfoAsync(requestModel.Email);

            if (customerInfo == null)
            {
                return this.NotFound();
            }

            var privileges = new List<string>();

            foreach (var privilege in customerInfo.Privileges)
            {
                foreach (var applicationPrivilege in privilege.ApplicationPrivileges)
                {
                    privileges.Add($"{applicationPrivilege.Id}:{applicationPrivilege.Scope}:{applicationPrivilege.Role}");
                }
            }

            var responseModel = new GetCustomerInfoResponseModel
            {
                Points = customerInfo.Points,
                Tier = customerInfo.Tier,
                Privileges = privileges
            };

            return this.Ok(responseModel);
        }
    }
}
