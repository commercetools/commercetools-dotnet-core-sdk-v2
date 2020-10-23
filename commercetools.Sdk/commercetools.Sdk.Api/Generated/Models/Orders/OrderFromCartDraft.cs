using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public  partial class OrderFromCartDraft : IOrderFromCartDraft
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public string OrderNumber { get; set;}
        
        public string PaymentState { get; set;}
        
        [JsonIgnore]
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
        
        public string ShipmentState { get; set;}
        
        [JsonIgnore]
        public ShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ShipmentState>();
        
        public string OrderState { get; set;}
        
        [JsonIgnore]
        public OrderState OrderStateAsEnum => this.OrderState.GetEnum<OrderState>();
        
        public IStateResourceIdentifier State { get; set;}
    }
}
