using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.MethodExternalTaxRateDraft))]
    public partial interface IMethodExternalTaxRateDraft
    {
        string ShippingMethodKey { get; set; }

        IExternalTaxRateDraft TaxRate { get; set; }

    }
}
