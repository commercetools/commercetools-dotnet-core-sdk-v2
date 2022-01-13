using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.ChangeAssetOrderChange))]
    public partial interface IChangeAssetOrderChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        List<ILocalizedString> PreviousValue { get; set; }

        List<ILocalizedString> NextValue { get; set; }
    }
}
