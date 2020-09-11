using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderSetReturnShipmentStateAction : OrderUpdateAction
    {
        public string ReturnItemId { get; set;}
        
        public ReturnShipmentState ShipmentState { get; set;}
    }
}
