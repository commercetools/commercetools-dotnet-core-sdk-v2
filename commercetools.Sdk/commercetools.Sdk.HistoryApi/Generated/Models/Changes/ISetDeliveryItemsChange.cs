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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDeliveryItemsChange))]
    public partial interface ISetDeliveryItemsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IDeliveryItem> PreviousValue { get; set; }
        IEnumerable<IDeliveryItem> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IDeliveryItem> NextValue { get; set; }
        IEnumerable<IDeliveryItem> NextValueEnumerable { set => NextValue = value.ToList(); }


        string DeliveryId { get; set; }

    }
}
