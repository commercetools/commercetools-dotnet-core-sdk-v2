using commercetools.Sdk.HistoryApi.Models.ChangeValues;
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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAssetSourcesChange))]
    public partial interface ISetAssetSourcesChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IList<IAssetSource> PreviousValue { get; set; }
        IEnumerable<IAssetSource> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IAssetSource> NextValue { get; set; }
        IEnumerable<IAssetSource> NextValueEnumerable { set => NextValue = value.ToList(); }


        IAssetChangeValue Asset { get; set; }

    }
}
