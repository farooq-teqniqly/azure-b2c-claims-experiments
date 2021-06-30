using System;

namespace CustomerApi.Models
{
    public class ApplicationPrivilege
    {
        public Guid Id { get; set; }
        public string Role { get; set; }

        public string Scope { get; set; }
    }
}