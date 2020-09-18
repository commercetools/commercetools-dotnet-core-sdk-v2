using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public class CustomerEmailVerify 
    {
        public long Version { get; set;}
        
        public string TokenValue { get; set;}
    }
}
