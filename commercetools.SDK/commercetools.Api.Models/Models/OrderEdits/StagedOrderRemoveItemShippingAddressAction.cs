using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("removeItemShippingAddress")]
    public class StagedOrderRemoveItemShippingAddressAction : StagedOrderUpdateAction
    {
        public string AddressKey { get; set;}
    }
}
