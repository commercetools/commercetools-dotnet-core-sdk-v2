using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetCustomLineItemTaxAmountAction))]
    public partial interface ICartSetCustomLineItemTaxAmountAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        IExternalTaxAmountDraft ExternalTaxAmount { get; set; }

    }
}
