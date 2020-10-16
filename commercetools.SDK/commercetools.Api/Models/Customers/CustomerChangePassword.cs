using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerChangePassword 
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public string CurrentPassword { get; set;}
        
        public string NewPassword { get; set;}
    }
}
