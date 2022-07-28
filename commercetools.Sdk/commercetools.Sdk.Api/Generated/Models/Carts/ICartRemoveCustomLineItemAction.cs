using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartRemoveCustomLineItemAction))]
    public partial interface ICartRemoveCustomLineItemAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

    }
}
