using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.MethodTaxedPrice))]
    public partial interface IMethodTaxedPrice
    {
        string ShippingMethodKey { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }

    }
}
