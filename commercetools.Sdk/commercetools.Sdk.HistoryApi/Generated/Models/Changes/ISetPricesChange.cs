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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetPricesChange))]
    public partial interface ISetPricesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IPrice> PreviousValue { get; set; }
        IEnumerable<IPrice> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IPrice> NextValue { get; set; }
        IEnumerable<IPrice> NextValueEnumerable { set => NextValue = value.ToList(); }


        string CatalogData { get; set; }

        string Variant { get; set; }

    }
}
