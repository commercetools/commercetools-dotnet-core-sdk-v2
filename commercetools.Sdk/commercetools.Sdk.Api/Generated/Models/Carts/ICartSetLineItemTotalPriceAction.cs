using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemTotalPriceAction))]
    public partial interface ICartSetLineItemTotalPriceAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

    }
}
