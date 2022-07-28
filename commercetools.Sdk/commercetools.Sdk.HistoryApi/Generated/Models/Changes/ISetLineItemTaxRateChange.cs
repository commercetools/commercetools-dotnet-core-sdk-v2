using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetLineItemTaxRateChange))]
    public partial interface ISetLineItemTaxRateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ILocalizedString LineItem { get; set; }

        string Variant { get; set; }

        ITaxMode TaxMode { get; set; }

        ITaxRate NextValue { get; set; }

        ITaxRate PreviousValue { get; set; }

    }
}
