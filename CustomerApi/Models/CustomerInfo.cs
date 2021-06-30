using System;
using System.Collections.Generic;

namespace CustomerApi.Models
{
    public class CustomerInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Privilege> Privileges { get; set; }
    }
}
