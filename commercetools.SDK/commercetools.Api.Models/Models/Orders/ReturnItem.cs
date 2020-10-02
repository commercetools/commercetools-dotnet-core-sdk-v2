using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [Discriminator(nameof(Type))]
    public abstract partial class ReturnItem 
    {
        public string Id { get; set;}
        
        public long Quantity { get; set;}
        
        public string Type { get; set;}
        
        public string Comment { get; set;}
        
        public string ShipmentState { get; set;}
        
        [JsonIgnore]
        public ReturnShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ReturnShipmentState>();
        
        public string PaymentState { get; set;}
        
        [JsonIgnore]
        public ReturnPaymentState PaymentStateAsEnum => this.PaymentState.GetEnum<ReturnPaymentState>();
        
        public DateTime LastModifiedAt { get; set;}
        
        public DateTime CreatedAt { get; set;}
    }
}
