using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderShipmentStateChangedMessagePayload : IOrderShipmentStateChangedMessagePayload
    {
        public string Type { get; set;}
        
        public string ShipmentState { get; set;}
        
        [JsonIgnore]
        public ShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ShipmentState>();
        
        public string OldShipmentState { get; set;}
        
        [JsonIgnore]
        public ShipmentState OldShipmentStateAsEnum => this.OldShipmentState.GetEnum<ShipmentState>();
        public OrderShipmentStateChangedMessagePayload()
        { 
           this.Type = "OrderShipmentStateChanged";
        }
    }
}
