using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartChangeCustomLineItemQuantityAction))]
    public partial interface ICartChangeCustomLineItemQuantityAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        long Quantity { get; set; }
    }
}
