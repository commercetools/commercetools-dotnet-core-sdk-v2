using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShoppingListLineItemCustomFieldChange))]
    public partial interface ISetShoppingListLineItemCustomFieldChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        Object PreviousValue { get; set; }

        Object NextValue { get; set; }

        string Name { get; set; }

        string CustomTypeId { get; set; }

        IShoppingListLineItemValue LineItem { get; set; }

    }
}
