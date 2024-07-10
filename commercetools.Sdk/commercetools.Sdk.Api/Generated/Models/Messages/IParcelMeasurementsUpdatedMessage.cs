using commercetools.Sdk.Api.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ParcelMeasurementsUpdatedMessage))]
    public partial interface IParcelMeasurementsUpdatedMessage : IOrderMessage
    {
        string DeliveryId { get; set; }

        string ParcelId { get; set; }

        IParcelMeasurements Measurements { get; set; }

        string ShippingKey { get; set; }

    }
}
