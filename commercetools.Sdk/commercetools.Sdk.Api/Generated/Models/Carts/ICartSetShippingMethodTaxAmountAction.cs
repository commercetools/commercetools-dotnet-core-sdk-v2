using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetShippingMethodTaxAmountAction))]
    public partial interface ICartSetShippingMethodTaxAmountAction : ICartUpdateAction
    {
        IExternalTaxAmountDraft ExternalTaxAmount { get; set; }
    }
}
