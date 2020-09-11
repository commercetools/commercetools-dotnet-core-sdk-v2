using commercetools.Api.Models.Orders;
using Newtonsoft.Json;
using JsonSubTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(CustomLineItemReturnItem), "CustomLineItemReturnItem")]
    [JsonSubtypes.KnownSubType(typeof(LineItemReturnItem), "LineItemReturnItem")]
    public abstract class ReturnItem 
    {
        public string Id { get; set;}
        
        public long Quantity { get; set;}
        
        public string Type { get; set;}
        
        public string Comment { get; set;}
        
        public ReturnShipmentState ShipmentState { get; set;}
        
        public ReturnPaymentState PaymentState { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public DateTime CreatedAt { get; set;}
    }
}
