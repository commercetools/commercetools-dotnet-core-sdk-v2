using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

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
