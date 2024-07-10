namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class MethodExternalTaxRateDraft : IMethodExternalTaxRateDraft
    {
        public string ShippingMethodKey { get; set; }

        public IExternalTaxRateDraft TaxRate { get; set; }
    }
}
