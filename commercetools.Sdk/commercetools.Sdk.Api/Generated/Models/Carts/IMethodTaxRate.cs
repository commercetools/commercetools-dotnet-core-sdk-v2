using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.MethodTaxRate))]
    public partial interface IMethodTaxRate
    {
        string ShippingMethodKey { get; set; }

        ITaxRate TaxRate { get; set; }

    }
}
