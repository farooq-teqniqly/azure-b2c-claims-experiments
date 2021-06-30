using System.Collections.Generic;
using AutoMapper;
using CustomerApi.Models;

namespace CustomerApi.Mappers
{
    public class GetCustomerInfoResponseModelTypeConverter : ITypeConverter<CustomerInfo, GetCustomerInfoResponseModel>
    {
        public GetCustomerInfoResponseModel Convert(CustomerInfo source, GetCustomerInfoResponseModel destination,
            ResolutionContext context)
        {
            var privileges = new List<string>();

            foreach (var privilege in source.Privileges)
            {
                foreach (var applicationPrivilege in privilege.ApplicationPrivileges)
                {
                    privileges.Add($"{applicationPrivilege.Id}:{applicationPrivilege.Scope}:{applicationPrivilege.Role}");
                }
            }

            return new GetCustomerInfoResponseModel
            {
                Points = source.Points,
                Tier = source.Tier,
                Privileges = privileges
            };

        }
    }
}
