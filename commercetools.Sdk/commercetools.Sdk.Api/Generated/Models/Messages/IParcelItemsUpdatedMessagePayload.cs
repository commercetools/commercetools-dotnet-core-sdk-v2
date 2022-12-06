using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ParcelItemsUpdatedMessagePayload))]
    public partial interface IParcelItemsUpdatedMessagePayload : IOrderMessagePayload
    {
        string ParcelId { get; set; }

        string DeliveryId { get; set; }

        IList<IDeliveryItem> Items { get; set; }
        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }


        IList<IDeliveryItem> OldItems { get; set; }
        IEnumerable<IDeliveryItem> OldItemsEnumerable { set => OldItems = value.ToList(); }


        string ShippingKey { get; set; }

    }
}
