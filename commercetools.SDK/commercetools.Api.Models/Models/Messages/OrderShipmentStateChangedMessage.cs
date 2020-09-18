using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderShipmentStateChanged")]
    public class OrderShipmentStateChangedMessage : Message
    {
        public string ShipmentState { get; set;}
        
        public ShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ShipmentState>();
        
        public string OldShipmentState { get; set;}
        
        public ShipmentState OldShipmentStateAsEnum => this.OldShipmentState.GetEnum<ShipmentState>();
    }
}
