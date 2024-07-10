using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDeliveryAddressChange))]
    public partial interface ISetDeliveryAddressChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IAddress PreviousValue { get; set; }

        IAddress NextValue { get; set; }

        string DeliveryId { get; set; }

    }
}
