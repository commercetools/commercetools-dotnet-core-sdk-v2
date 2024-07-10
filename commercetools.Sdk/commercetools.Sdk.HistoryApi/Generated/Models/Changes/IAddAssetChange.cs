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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddAssetChange))]
    public partial interface IAddAssetChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAsset PreviousValue { get; set; }

        IAsset NextValue { get; set; }

    }
}
