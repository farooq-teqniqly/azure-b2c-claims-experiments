using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CustomerApi.Models
{
    public class GetCustomerInfoResponseModel
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Tier Tier { get; set; }
        public int Points { get; set; }
        public IEnumerable<string> Privileges { get; set; }
    }
}