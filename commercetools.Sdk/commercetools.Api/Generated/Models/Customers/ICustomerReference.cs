using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Customers
{
    public interface ICustomerReference : IReference
    {
        ICustomer Obj { get; set;}
    }
}
