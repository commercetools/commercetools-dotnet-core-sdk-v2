using commercetools.Api.Generated.Models.Customers;
using commercetools.Api.Generated.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Customers
{
    public interface ICustomerSetStoresAction : ICustomerUpdateAction
    {
        List<IStoreResourceIdentifier> Stores { get; set;}
    }
}
