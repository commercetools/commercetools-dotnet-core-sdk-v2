using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemQuantityAction))]
    public partial interface ICartChangeCustomLineItemQuantityAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        long Quantity { get; set; }

    }
}
