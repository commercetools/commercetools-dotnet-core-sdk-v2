using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemTaxRateAction))]
    public partial interface ICartSetLineItemTaxRateAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        string ShippingKey { get; set; }

    }
}
