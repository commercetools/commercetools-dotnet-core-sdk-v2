using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderSetStoreAction : OrderUpdateAction
    {
        public StoreResourceIdentifier Store { get; set;}
    }
}
