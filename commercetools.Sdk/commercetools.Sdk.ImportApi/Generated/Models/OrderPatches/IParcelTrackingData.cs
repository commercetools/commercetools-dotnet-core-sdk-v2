using commercetools.Sdk.ImportApi.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.OrderPatches
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.OrderPatches.ParcelTrackingData))]
    public partial interface IParcelTrackingData
    {
        string ParcelId { get; set; }

        ITrackingData TrackingData { get; set; }

    }
}
