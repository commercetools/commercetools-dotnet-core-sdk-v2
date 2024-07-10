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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetVariantAvailabilityChange))]
    public partial interface ISetVariantAvailabilityChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IProductVariantAvailability PreviousValue { get; set; }

        IProductVariantAvailability NextValue { get; set; }

        string CatalogData { get; set; }

        string Variant { get; set; }

    }
}
