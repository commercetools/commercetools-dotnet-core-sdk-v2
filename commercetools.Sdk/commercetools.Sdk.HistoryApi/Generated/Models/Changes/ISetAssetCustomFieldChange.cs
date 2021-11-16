using commercetools.HistoryApi.Models.ChangeValues;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetAssetCustomFieldChange))]
    public partial interface ISetAssetCustomFieldChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        string Name { get; set; }

        string CustomTypeId { get; set; }

        IAssetChangeValue Asset { get; set; }

        Object NextValue { get; set; }

        Object PreviousValue { get; set; }
    }
}
