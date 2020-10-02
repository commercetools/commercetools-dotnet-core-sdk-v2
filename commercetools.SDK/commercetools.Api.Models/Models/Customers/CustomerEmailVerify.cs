using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerEmailVerify 
    {
        public long Version { get; set;}
        
        public string TokenValue { get; set;}
    }
}
