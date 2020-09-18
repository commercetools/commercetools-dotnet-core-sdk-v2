using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setStore")]
    public class OrderSetStoreAction : OrderUpdateAction
    {
        public StoreResourceIdentifier Store { get; set;}
    }
}
