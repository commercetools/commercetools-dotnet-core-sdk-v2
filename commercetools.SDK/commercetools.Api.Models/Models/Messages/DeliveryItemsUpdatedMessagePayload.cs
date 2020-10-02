using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("DeliveryItemsUpdated")]
    public partial class DeliveryItemsUpdatedMessagePayload : MessagePayload
    {
        public string DeliveryId { get; set;}
        
        public List<DeliveryItem> Items { get; set;}
        
        public List<DeliveryItem> OldItems { get; set;}
        public DeliveryItemsUpdatedMessagePayload()
        { 
           this.Type = "DeliveryItemsUpdated";
        }
    }
}
