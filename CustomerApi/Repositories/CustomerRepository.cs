using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApi.Models;

namespace CustomerApi.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly List<CustomerInfo> customerInfos = new List<CustomerInfo>
        {
            new CustomerInfo
            {
                Id = Guid.Parse("9fa06113-5a99-448f-ab96-62ae065950ae"),
                Name = "I.P. Freely",
                Privileges = new List<Privilege>
                {
                    new Privilege
                    {
                        ApplicationPrivileges = new List<ApplicationPrivilege>
                        {
                            new ApplicationPrivilege
                            {
                                Id = Guid.Parse("4758f934-33e2-42fa-934b-e95c45ec9bd0"),
                                Role = "Reader",
                                Scope = "/farooqent/customer-portal"
                            },
                            new ApplicationPrivilege
                            {
                                Id = Guid.Parse("4758f934-33e2-42fa-934b-e95c45ec9bd0"),
                                Role = "Writer",
                                Scope = "/farooqent/customer-portal"
                            }
                        }
                    }
                }

            }
        };

        public Task<CustomerInfo> GetCustomerInfoAsync(Guid id)
        {
            return Task.FromResult(
                this.customerInfos.SingleOrDefault(
                    ci => ci.Id == id));
        }
    }
}
