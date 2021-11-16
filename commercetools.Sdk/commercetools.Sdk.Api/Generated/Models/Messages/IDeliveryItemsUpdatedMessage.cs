using commercetools.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.DeliveryItemsUpdatedMessage))]
    public partial interface IDeliveryItemsUpdatedMessage : IMessage
    {
        string DeliveryId { get; set;}
        
        List<IDeliveryItem> Items { get; set;}
        
        List<IDeliveryItem> OldItems { get; set;}
    }
}
