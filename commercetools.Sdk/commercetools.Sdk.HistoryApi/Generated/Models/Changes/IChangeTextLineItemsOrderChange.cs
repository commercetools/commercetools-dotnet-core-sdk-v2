using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeTextLineItemsOrderChange))]
    public partial interface IChangeTextLineItemsOrderChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        List<ITextLineItemValue> PreviousValue { get; set; }

        List<ITextLineItemValue> NextValue { get; set; }

    }
}
