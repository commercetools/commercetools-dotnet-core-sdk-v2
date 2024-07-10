using commercetools.Sdk.Api.Models.Orders;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.OrderEdits.StagedOrderAddParcelToDeliveryAction))]
    public partial interface IStagedOrderAddParcelToDeliveryAction : IStagedOrderUpdateAction
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
