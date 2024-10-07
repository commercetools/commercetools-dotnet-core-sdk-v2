using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodTaxRateAction))]
    public partial interface ICartSetShippingMethodTaxRateAction : ICartUpdateAction
    {
        string ShippingKey { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

    }
}
