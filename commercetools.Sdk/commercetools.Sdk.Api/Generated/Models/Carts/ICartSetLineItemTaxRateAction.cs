using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemTaxRateAction))]
    public partial interface ICartSetLineItemTaxRateAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }
    }
}
