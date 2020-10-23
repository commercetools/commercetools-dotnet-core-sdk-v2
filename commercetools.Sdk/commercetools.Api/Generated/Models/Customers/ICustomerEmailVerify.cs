using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Customers
{
    public interface ICustomerEmailVerify 
    {
        long Version { get; set;}
        
        string TokenValue { get; set;}
    }
}
