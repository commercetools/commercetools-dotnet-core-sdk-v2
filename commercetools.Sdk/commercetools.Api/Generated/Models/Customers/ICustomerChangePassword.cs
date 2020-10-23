using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Customers
{
    public interface ICustomerChangePassword 
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        string CurrentPassword { get; set;}
        
        string NewPassword { get; set;}
    }
}
