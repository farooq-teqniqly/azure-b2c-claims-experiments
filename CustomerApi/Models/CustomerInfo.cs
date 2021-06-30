using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CustomerApi.Models
{
    public class CustomerInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Tier Tier { get; set; }
        public int Points { get; set; }
        public IEnumerable<Privilege> Privileges { get; set; }
    }
}
