using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAssetCustomFieldChange))]
    public partial interface ISetAssetCustomFieldChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        Object PreviousValue { get; set; }

        Object NextValue { get; set; }

        string Name { get; set; }

        string CustomTypeId { get; set; }

        IAssetChangeValue Asset { get; set; }

    }
}
