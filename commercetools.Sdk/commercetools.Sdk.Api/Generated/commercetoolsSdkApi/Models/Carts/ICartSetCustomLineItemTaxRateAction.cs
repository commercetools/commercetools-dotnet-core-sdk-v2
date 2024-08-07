using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemTaxRateAction))]
    public partial interface ICartSetCustomLineItemTaxRateAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        string CustomLineItemKey { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        string ShippingKey { get; set; }

    }
}
