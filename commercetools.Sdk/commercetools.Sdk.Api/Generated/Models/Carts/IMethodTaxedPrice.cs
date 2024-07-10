using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.MethodTaxedPrice))]
    public partial interface IMethodTaxedPrice
    {
        string ShippingMethodKey { get; set; }

        ITaxedItemPrice TaxedPrice { get; set; }

    }
}
