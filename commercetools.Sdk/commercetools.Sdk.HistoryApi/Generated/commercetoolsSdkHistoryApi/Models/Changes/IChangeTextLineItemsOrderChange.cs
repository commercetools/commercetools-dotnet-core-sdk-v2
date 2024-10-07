using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemsOrderChange))]
    public partial interface IChangeTextLineItemsOrderChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<ITextLineItemValue> PreviousValue { get; set; }

        IEnumerable<ITextLineItemValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<ITextLineItemValue> NextValue { get; set; }

        IEnumerable<ITextLineItemValue> NextValueEnumerable { set => NextValue = value.ToList(); }

    }
}
