using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeShoppingListLineItemsOrderChange))]
    public partial interface IChangeShoppingListLineItemsOrderChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IShoppingListLineItemValue> PreviousValue { get; set; }
        IEnumerable<IShoppingListLineItemValue> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IShoppingListLineItemValue> NextValue { get; set; }
        IEnumerable<IShoppingListLineItemValue> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
