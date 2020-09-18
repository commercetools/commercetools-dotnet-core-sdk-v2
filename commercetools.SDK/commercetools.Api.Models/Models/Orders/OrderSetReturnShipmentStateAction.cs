using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setReturnShipmentState")]
    public class OrderSetReturnShipmentStateAction : OrderUpdateAction
    {
        public string ReturnItemId { get; set;}
        
        public string ShipmentState { get; set;}
        
        public ReturnShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ReturnShipmentState>();
    }
}
