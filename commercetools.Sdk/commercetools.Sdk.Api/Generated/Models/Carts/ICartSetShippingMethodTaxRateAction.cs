using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetShippingMethodTaxRateAction))]
    public partial interface ICartSetShippingMethodTaxRateAction : ICartUpdateAction
    {
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
