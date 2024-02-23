using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryItemsUpdatedMessagePayload))]
    public partial interface IDeliveryItemsUpdatedMessagePayload : IOrderMessagePayload
    {
        string DeliveryId { get; set; }

        IList<IDeliveryItem> Items { get; set; }
        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        IList<IDeliveryItem> OldItems { get; set; }
        IEnumerable<IDeliveryItem> OldItemsEnumerable { set => OldItems = value.ToList(); }


        string ShippingKey { get; set; }

    }
}
