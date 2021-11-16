using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartSetCustomLineItemTaxRateAction))]
    public partial interface ICartSetCustomLineItemTaxRateAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set;}
        
        IExternalTaxRateDraft ExternalTaxRate { get; set;}
    }
}
