using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodTaxAmountAction))]
    public partial interface ICartSetShippingMethodTaxAmountAction : ICartUpdateAction
    {
        string ShippingKey { get; set; }

        IExternalTaxAmountDraft ExternalTaxAmount { get; set; }

    }
}
