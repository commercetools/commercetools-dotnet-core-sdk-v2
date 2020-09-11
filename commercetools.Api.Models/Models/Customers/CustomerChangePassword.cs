using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    public class CustomerChangePassword 
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public string CurrentPassword { get; set;}
        
        public string NewPassword { get; set;}
    }
}
