using commercetools.Api.Generated.Models.Messages;
using commercetools.Api.Generated.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IParcelItemsUpdatedMessagePayload : IMessagePayload
    {
        string ParcelId { get; set;}
        
        string DeliveryId { get; set;}
        
        List<IDeliveryItem> Items { get; set;}
        
        List<IDeliveryItem> OldItems { get; set;}
    }
}
