using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.MethodTaxRate))]
    public partial interface IMethodTaxRate
    {
        string ShippingMethodKey { get; set; }

        ITaxRate TaxRate { get; set; }

    }
}
