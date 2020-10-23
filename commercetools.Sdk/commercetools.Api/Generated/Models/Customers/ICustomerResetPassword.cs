using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Customers
{
    public interface ICustomerResetPassword 
    {
        string TokenValue { get; set;}
        
        string NewPassword { get; set;}
        
        long Version { get; set;}
    }
}
