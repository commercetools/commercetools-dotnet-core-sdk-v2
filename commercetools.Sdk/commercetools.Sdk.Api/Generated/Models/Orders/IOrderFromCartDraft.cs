using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderFromCartDraft))]
    public interface IOrderFromCartDraft 
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        string OrderNumber { get; set;}
        
        string PaymentState { get; set;}
        
        PaymentState PaymentStateAsEnum { get; }
        
        string ShipmentState { get; set;}
        
        ShipmentState ShipmentStateAsEnum { get; }
        
        string OrderState { get; set;}
        
        OrderState OrderStateAsEnum { get; }
        
        IStateResourceIdentifier State { get; set;}
    }
}
