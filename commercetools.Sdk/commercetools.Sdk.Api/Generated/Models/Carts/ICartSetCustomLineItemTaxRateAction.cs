using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemTaxRateAction))]
    public partial interface ICartSetCustomLineItemTaxRateAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }
    }
}
