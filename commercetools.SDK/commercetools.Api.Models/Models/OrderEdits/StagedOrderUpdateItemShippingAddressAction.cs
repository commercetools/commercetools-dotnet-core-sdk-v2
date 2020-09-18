using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("updateItemShippingAddress")]
    public class StagedOrderUpdateItemShippingAddressAction : StagedOrderUpdateAction
    {
        public Address Address { get; set;}
    }
}
