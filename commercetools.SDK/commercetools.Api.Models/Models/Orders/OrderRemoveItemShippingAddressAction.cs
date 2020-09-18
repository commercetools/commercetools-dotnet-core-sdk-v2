using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("removeItemShippingAddress")]
    public class OrderRemoveItemShippingAddressAction : OrderUpdateAction
    {
        public string AddressKey { get; set;}
    }
}
