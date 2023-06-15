using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemPriceChange))]
    public partial interface ISetLineItemPriceChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IPrice PreviousValue { get; set; }

        IPrice NextValue { get; set; }

        ILocalizedString LineItem { get; set; }

    }
}
