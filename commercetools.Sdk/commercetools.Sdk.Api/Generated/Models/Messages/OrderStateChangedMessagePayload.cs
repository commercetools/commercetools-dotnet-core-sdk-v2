using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderStateChangedMessagePayload : IOrderStateChangedMessagePayload
    {
        public string Type { get; set;}
        
        public string OrderState { get; set;}
        
        [JsonIgnore]
        public OrderState OrderStateAsEnum => this.OrderState.GetEnum<OrderState>();
        
        public string OldOrderState { get; set;}
        
        [JsonIgnore]
        public OrderState OldOrderStateAsEnum => this.OldOrderState.GetEnum<OrderState>();
        public OrderStateChangedMessagePayload()
        { 
           this.Type = "OrderStateChanged";
        }
    }
}
