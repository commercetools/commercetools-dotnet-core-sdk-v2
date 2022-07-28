using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetProductSelectionsChange))]
    public partial interface ISetProductSelectionsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        List<IProductSelectionSetting> PreviousValue { get; set; }

        List<IProductSelectionSetting> NextValue { get; set; }

    }
}
