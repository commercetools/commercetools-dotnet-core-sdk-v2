using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ParcelItemsUpdatedMessagePayload))]
    public partial interface IParcelItemsUpdatedMessagePayload : IOrderMessagePayload
    {
        string ParcelId { get; set; }

        string DeliveryId { get; set; }

        List<IDeliveryItem> Items { get; set; }

        List<IDeliveryItem> OldItems { get; set; }

        string ShippingKey { get; set; }

    }
}
