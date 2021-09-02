using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetAssetSourcesChange))]
    public partial interface ISetAssetSourcesChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IAssetChangeValue Asset { get; set; }

        List<IAssetSource> NextValue { get; set; }

        List<IAssetSource> PreviousValue { get; set; }
    }
}
