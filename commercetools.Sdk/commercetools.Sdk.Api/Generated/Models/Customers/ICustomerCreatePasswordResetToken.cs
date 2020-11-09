using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerCreatePasswordResetToken))]
    public partial interface ICustomerCreatePasswordResetToken 
    {
        string Email { get; set;}
        
        long? TtlMinutes { get; set;}
    }
}
