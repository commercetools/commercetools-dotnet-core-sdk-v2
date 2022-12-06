using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeAssetOrderChange))]
    public partial interface IChangeAssetOrderChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<ILocalizedString> PreviousValue { get; set; }
        IEnumerable<ILocalizedString> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<ILocalizedString> NextValue { get; set; }
        IEnumerable<ILocalizedString> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
