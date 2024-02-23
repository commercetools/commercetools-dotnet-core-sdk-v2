using commercetools.Sdk.Api.Models.ShippingMethods;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomShippingMethodAction))]
    public partial interface ICartSetCustomShippingMethodAction : ICartUpdateAction
    {
        string ShippingMethodName { get; set; }

        IShippingRateDraft ShippingRate { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

    }
}
