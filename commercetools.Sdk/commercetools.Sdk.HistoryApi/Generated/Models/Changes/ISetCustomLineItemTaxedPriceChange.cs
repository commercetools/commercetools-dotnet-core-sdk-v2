using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomLineItemTaxedPriceChange))]
    public partial interface ISetCustomLineItemTaxedPriceChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ILocalizedString CustomLineItem { get; set; }

        string CustomLineItemId { get; set; }

        IMoney NextValue { get; set; }

        IMoney PreviousValue { get; set; }

    }
}
