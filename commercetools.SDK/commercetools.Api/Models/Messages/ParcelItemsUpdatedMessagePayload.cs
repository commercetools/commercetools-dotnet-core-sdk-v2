using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ParcelItemsUpdated")]
    public partial class ParcelItemsUpdatedMessagePayload : MessagePayload
    {
        public string ParcelId { get; set;}
        
        public string DeliveryId { get; set;}
        
        public List<DeliveryItem> Items { get; set;}
        
        public List<DeliveryItem> OldItems { get; set;}
        public ParcelItemsUpdatedMessagePayload()
        { 
           this.Type = "ParcelItemsUpdated";
        }
    }
}
