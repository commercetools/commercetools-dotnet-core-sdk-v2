using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class ParcelItemsUpdatedMessagePayload : IParcelItemsUpdatedMessagePayload
    {
        public string Type { get; set;}
        
        public string ParcelId { get; set;}
        
        public string DeliveryId { get; set;}
        
        public List<IDeliveryItem> Items { get; set;}
        
        public List<IDeliveryItem> OldItems { get; set;}
        public ParcelItemsUpdatedMessagePayload()
        { 
           this.Type = "ParcelItemsUpdated";
        }
    }
}
