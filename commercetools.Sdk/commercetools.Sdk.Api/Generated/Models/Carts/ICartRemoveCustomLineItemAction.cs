using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartRemoveCustomLineItemAction))]
    public partial interface ICartRemoveCustomLineItemAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }
    }
}
