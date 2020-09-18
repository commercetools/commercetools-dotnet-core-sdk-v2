using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("changeShipmentState")]
    public class OrderChangeShipmentStateAction : OrderUpdateAction
    {
        public string ShipmentState { get; set;}
        
        public ShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ShipmentState>();
    }
}
