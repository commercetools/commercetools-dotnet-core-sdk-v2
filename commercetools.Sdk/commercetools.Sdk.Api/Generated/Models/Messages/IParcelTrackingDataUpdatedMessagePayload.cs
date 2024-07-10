using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ParcelTrackingDataUpdatedMessagePayload))]
    public partial interface IParcelTrackingDataUpdatedMessagePayload : IOrderMessagePayload
    {
        string DeliveryId { get; set; }

        string ParcelId { get; set; }

        ITrackingData TrackingData { get; set; }

        string ShippingKey { get; set; }

    }
}
