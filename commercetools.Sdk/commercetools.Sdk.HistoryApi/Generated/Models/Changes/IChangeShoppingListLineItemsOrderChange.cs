using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeShoppingListLineItemsOrderChange))]
    public partial interface IChangeShoppingListLineItemsOrderChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        List<IShoppingListLineItemValue> PreviousValue { get; set; }

        List<IShoppingListLineItemValue> NextValue { get; set; }

    }
}
