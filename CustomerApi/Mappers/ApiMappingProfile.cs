using AutoMapper;
using CustomerApi.Models;

namespace CustomerApi.Mappers
{
    public class ApiMappingProfile : Profile
    {
        public ApiMappingProfile()
        {
            this.CreateMap<CustomerInfo, GetCustomerInfoResponseModel>()
                .ConvertUsing<GetCustomerInfoResponseModelTypeConverter>();
        }
    }
}
