using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryItemsUpdatedMessage))]
    public partial interface IDeliveryItemsUpdatedMessage : IOrderMessage
    {
        string DeliveryId { get; set; }

        List<IDeliveryItem> Items { get; set; }

        List<IDeliveryItem> OldItems { get; set; }
    }
}
