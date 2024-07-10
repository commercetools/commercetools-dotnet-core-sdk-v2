namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class MethodTaxedPrice : IMethodTaxedPrice
    {
        public string ShippingMethodKey { get; set; }

        public ITaxedItemPrice TaxedPrice { get; set; }
    }
}
