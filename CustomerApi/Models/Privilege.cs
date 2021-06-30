using System.Collections.Generic;

namespace CustomerApi.Models
{
    public class Privilege
    {
        public IEnumerable<ApplicationPrivilege> ApplicationPrivileges { get; set; }    
    }
}