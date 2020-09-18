using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("removeParcelFromDelivery")]
    public class OrderRemoveParcelFromDeliveryAction : OrderUpdateAction
    {
        public string ParcelId { get; set;}
    }
}
