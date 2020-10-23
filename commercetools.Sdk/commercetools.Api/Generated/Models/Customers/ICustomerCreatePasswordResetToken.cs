using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Customers
{
    public interface ICustomerCreatePasswordResetToken 
    {
        string Email { get; set;}
        
        long TtlMinutes { get; set;}
    }
}
