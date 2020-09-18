using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ParcelRemovedFromDelivery")]
    public class ParcelRemovedFromDeliveryMessage : Message
    {
        public string DeliveryId { get; set;}
        
        public Parcel Parcel { get; set;}
    }
}
