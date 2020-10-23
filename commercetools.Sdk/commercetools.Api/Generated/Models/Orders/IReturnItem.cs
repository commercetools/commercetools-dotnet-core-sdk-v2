using commercetools.Api.Generated.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Orders
{
    public interface IReturnItem 
    {
        string Id { get; set;}
        
        long Quantity { get; set;}
        
        string Type { get; set;}
        
        string Comment { get; set;}
        
        string ShipmentState { get; set;}
        
        ReturnShipmentState ShipmentStateAsEnum { get; }
        
        string PaymentState { get; set;}
        
        ReturnPaymentState PaymentStateAsEnum { get; }
        
        DateTime LastModifiedAt { get; set;}
        
        DateTime CreatedAt { get; set;}
    }
}
