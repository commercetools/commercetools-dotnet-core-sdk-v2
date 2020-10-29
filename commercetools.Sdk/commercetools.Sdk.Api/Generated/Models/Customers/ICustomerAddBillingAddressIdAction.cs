using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerAddBillingAddressIdAction))]
    public interface ICustomerAddBillingAddressIdAction : ICustomerUpdateAction
    {
        string AddressId { get; set;}
        
        string AddressKey { get; set;}
    }
}
