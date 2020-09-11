using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderRemoveParcelFromDeliveryAction : OrderUpdateAction
    {
        public string ParcelId { get; set;}
    }
}
