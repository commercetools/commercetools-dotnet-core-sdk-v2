using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.AddShoppingListLineItemChange))]
    public partial interface IAddShoppingListLineItemChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ILineItem PreviousValue { get; set; }

        ILineItem NextValue { get; set; }

    }
}
