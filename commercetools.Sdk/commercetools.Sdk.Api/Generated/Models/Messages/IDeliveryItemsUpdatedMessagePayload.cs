using commercetools.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.DeliveryItemsUpdatedMessagePayload))]
    public partial interface IDeliveryItemsUpdatedMessagePayload : IMessagePayload
    {
        string DeliveryId { get; set; }

        List<IDeliveryItem> Items { get; set; }

        List<IDeliveryItem> OldItems { get; set; }
    }
}
