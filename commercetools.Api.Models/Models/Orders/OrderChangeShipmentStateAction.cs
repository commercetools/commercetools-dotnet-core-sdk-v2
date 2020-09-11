using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderChangeShipmentStateAction : OrderUpdateAction
    {
        public ShipmentState ShipmentState { get; set;}
    }
}
