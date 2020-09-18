using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public class CustomerResetPassword 
    {
        public string TokenValue { get; set;}
        
        public string NewPassword { get; set;}
        
        public long Version { get; set;}
    }
}
