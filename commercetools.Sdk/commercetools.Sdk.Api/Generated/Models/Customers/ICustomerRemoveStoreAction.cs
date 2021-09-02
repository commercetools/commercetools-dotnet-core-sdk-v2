using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DeserializeAs(typeof(commercetools.Api.Models.Customers.CustomerRemoveStoreAction))]
    public partial interface ICustomerRemoveStoreAction : ICustomerUpdateAction
    {
        IStoreResourceIdentifier Store { get; set; }
    }
}
