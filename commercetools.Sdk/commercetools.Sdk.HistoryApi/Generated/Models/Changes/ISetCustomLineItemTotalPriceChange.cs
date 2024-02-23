using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTotalPriceChange))]
    public partial interface ISetCustomLineItemTotalPriceChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IMoney PreviousValue { get; set; }

        IMoney NextValue { get; set; }

        ILocalizedString CustomLineItem { get; set; }

        string CustomLineItemId { get; set; }

    }
}
