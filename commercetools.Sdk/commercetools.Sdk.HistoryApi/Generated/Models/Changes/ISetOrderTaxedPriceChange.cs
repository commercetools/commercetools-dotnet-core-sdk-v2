using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetOrderTaxedPriceChange))]
    public partial interface ISetOrderTaxedPriceChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ITaxMode TaxMode { get; set; }

        ITaxedItemPrice NextValue { get; set; }

        ITaxedItemPrice PreviousValue { get; set; }
    }
}
