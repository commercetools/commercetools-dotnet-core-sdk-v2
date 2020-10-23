using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerReference))]
    public interface ICustomerReference : IReference
    {
        ICustomer Obj { get; set;}
    }
}
