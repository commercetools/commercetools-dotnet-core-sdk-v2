using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerEmailVerify))]
    public interface ICustomerEmailVerify 
    {
        long Version { get; set;}
        
        string TokenValue { get; set;}
    }
}
