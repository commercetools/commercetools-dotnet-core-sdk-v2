using commercetools.Sdk.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetTaxedShippingPriceChange))]
    public partial interface ISetTaxedShippingPriceChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        ITaxedPrice PreviousValue { get; set; }

        ITaxedPrice NextValue { get; set; }

    }
}
