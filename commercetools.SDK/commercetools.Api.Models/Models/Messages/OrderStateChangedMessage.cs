using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderStateChanged")]
    public partial class OrderStateChangedMessage : Message
    {
        public string OrderState { get; set;}
        
        [JsonIgnore]
        public OrderState OrderStateAsEnum => this.OrderState.GetEnum<OrderState>();
        
        public string OldOrderState { get; set;}
        
        [JsonIgnore]
        public OrderState OldOrderStateAsEnum => this.OldOrderState.GetEnum<OrderState>();
        public OrderStateChangedMessage()
        { 
           this.Type = "OrderStateChanged";
        }
    }
}
