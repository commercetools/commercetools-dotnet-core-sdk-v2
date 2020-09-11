using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderSetBillingAddressAction : OrderUpdateAction
    {
        public Address Address { get; set;}
    }
}
