using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setStores")]
    public class CustomerSetStoresAction : CustomerUpdateAction
    {
        public List<StoreResourceIdentifier> Stores { get; set;}
    }
}
