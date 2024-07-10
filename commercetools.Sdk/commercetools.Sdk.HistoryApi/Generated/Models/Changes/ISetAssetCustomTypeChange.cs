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
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAssetCustomTypeChange))]
    public partial interface ISetAssetCustomTypeChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        ICustomFields PreviousValue { get; set; }

        ICustomFields NextValue { get; set; }

        IAssetChangeValue Asset { get; set; }

    }
}
