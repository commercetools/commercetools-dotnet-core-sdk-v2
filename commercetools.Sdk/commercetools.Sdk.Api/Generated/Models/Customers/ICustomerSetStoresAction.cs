using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerSetStoresAction))]
    public interface ICustomerSetStoresAction : ICustomerUpdateAction
    {
        List<IStoreResourceIdentifier> Stores { get; set;}
    }
}
