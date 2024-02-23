using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetShippingMethodTaxRateChange))]
    public partial interface ISetShippingMethodTaxRateChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ITaxRate PreviousValue { get; set; }

        ITaxRate NextValue { get; set; }

        ITaxMode TaxMode { get; set; }

    }
}
