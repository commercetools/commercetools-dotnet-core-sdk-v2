using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setShippingAddress")]
    public class OrderSetShippingAddressAction : OrderUpdateAction
    {
        public Address Address { get; set;}
    }
}
