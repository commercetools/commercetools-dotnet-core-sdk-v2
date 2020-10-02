using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderReturnShipmentStateChanged")]
    public partial class OrderReturnShipmentStateChangedMessage : Message
    {
        public string ReturnItemId { get; set;}
        
        public string ReturnShipmentState { get; set;}
        
        [JsonIgnore]
        public ReturnShipmentState ReturnShipmentStateAsEnum => this.ReturnShipmentState.GetEnum<ReturnShipmentState>();
        public OrderReturnShipmentStateChangedMessage()
        { 
           this.Type = "OrderReturnShipmentStateChanged";
        }
    }
}
