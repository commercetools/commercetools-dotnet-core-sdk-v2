using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemTaxAmountAction))]
    public partial interface ICartSetLineItemTaxAmountAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        IExternalTaxAmountDraft ExternalTaxAmount { get; set; }

        string ShippingKey { get; set; }

    }
}
