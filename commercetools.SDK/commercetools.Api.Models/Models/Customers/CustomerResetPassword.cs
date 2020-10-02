using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerResetPassword 
    {
        public string TokenValue { get; set;}
        
        public string NewPassword { get; set;}
        
        public long Version { get; set;}
    }
}
