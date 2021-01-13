using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("CustomLineItemReturnItem", typeof(commercetools.Api.Models.Orders.CustomLineItemReturnItem))]
    [SubTypeDiscriminator("LineItemReturnItem", typeof(commercetools.Api.Models.Orders.LineItemReturnItem))]
    public partial interface IReturnItem 
    {
        string Id { get; set;}
        
        long Quantity { get; set;}
        
        string Type { get; set;}
        
        string Comment { get; set;}
        
        IReturnShipmentState ShipmentState { get; set;}
        
        IReturnPaymentState PaymentState { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        DateTime CreatedAt { get; set;}
    }
}
