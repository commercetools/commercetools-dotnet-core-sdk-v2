using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("removeStore")]
    public class CustomerRemoveStoreAction : CustomerUpdateAction
    {
        public StoreResourceIdentifier Store { get; set;}
    }
}
