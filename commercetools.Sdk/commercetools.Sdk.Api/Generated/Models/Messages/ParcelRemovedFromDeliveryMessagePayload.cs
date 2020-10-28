using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class ParcelRemovedFromDeliveryMessagePayload : IParcelRemovedFromDeliveryMessagePayload
    {
        public string Type { get; set;}
        
        public string DeliveryId { get; set;}
        
        public IParcel Parcel { get; set;}
        public ParcelRemovedFromDeliveryMessagePayload()
        { 
           this.Type = "ParcelRemovedFromDelivery";
        }
    }
}
