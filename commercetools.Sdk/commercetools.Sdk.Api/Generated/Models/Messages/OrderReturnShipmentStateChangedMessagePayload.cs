using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public  partial class OrderReturnShipmentStateChangedMessagePayload : IOrderReturnShipmentStateChangedMessagePayload
    {
        public string Type { get; set;}
        
        public string ReturnItemId { get; set;}
        
        public string ReturnShipmentState { get; set;}
        
        [JsonIgnore]
        public ReturnShipmentState ReturnShipmentStateAsEnum => this.ReturnShipmentState.GetEnum<ReturnShipmentState>();
        public OrderReturnShipmentStateChangedMessagePayload()
        { 
           this.Type = "OrderReturnShipmentStateChanged";
        }
    }
}
