using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemTaxAmountAction))]
    public partial interface ICartSetCustomLineItemTaxAmountAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        IExternalTaxAmountDraft ExternalTaxAmount { get; set; }
    }
}
