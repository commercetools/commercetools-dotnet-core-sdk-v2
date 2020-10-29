using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ParcelItemsUpdatedMessagePayload))]
    public interface IParcelItemsUpdatedMessagePayload : IMessagePayload
    {
        string ParcelId { get; set;}
        
        string DeliveryId { get; set;}
        
        List<IDeliveryItem> Items { get; set;}
        
        List<IDeliveryItem> OldItems { get; set;}
    }
}
