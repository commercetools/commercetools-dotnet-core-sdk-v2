using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetProductSelectionsChange))]
    public partial interface ISetProductSelectionsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IProductSelectionSetting> PreviousValue { get; set; }

        IEnumerable<IProductSelectionSetting> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<IProductSelectionSetting> NextValue { get; set; }

        IEnumerable<IProductSelectionSetting> NextValueEnumerable { set => NextValue = value.ToList(); }

    }
}
