using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public class OrderFromCartDraft 
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public string OrderNumber { get; set;}
        
        public string PaymentState { get; set;}
        
        public PaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<PaymentState>();
        
        public string ShipmentState { get; set;}
        
        public ShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ShipmentState>();
        
        public string OrderState { get; set;}
        
        public OrderState OrderStateAsEnum => this.OrderState.GetEnum<OrderState>();
        
        public StateResourceIdentifier State { get; set;}
    }
}
