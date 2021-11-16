using commercetools.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ParcelItemsUpdatedMessagePayload))]
    public partial interface IParcelItemsUpdatedMessagePayload : IMessagePayload
    {
        string ParcelId { get; set; }

        string DeliveryId { get; set; }

        List<IDeliveryItem> Items { get; set; }

        List<IDeliveryItem> OldItems { get; set; }
    }
}
