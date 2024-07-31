using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Orders.OrderAddParcelToDeliveryAction))]
    public partial interface IOrderAddParcelToDeliveryAction : IOrderUpdateAction
    {
        string DeliveryId { get; set; }

        string DeliveryKey { get; set; }

        string ParcelKey { get; set; }

        IParcelMeasurements Measurements { get; set; }

        ITrackingData TrackingData { get; set; }

        IList<IDeliveryItem> Items { get; set; }

        IEnumerable<IDeliveryItem> ItemsEnumerable { set => Items = value.ToList(); }

        ICustomFieldsDraft Custom { get; set; }

    }
}
