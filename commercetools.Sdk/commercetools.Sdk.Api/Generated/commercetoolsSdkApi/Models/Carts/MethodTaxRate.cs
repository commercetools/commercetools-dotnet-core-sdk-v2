using commercetools.Sdk.Api.Models.TaxCategories;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class MethodTaxRate : IMethodTaxRate
    {
        public string ShippingMethodKey { get; set; }

        public ITaxRate TaxRate { get; set; }
    }
}
