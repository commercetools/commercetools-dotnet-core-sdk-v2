using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerEmailVerify : ICustomerEmailVerify
    {
        public long? Version { get; set;}
        
        public string TokenValue { get; set;}
    }
}
