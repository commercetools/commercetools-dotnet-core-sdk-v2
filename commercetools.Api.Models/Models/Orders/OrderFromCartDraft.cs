using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderFromCartDraft 
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public string OrderNumber { get; set;}
        
        public PaymentState PaymentState { get; set;}
        
        public ShipmentState ShipmentState { get; set;}
        
        public OrderState OrderState { get; set;}
        
        public StateResourceIdentifier State { get; set;}
    }
}
