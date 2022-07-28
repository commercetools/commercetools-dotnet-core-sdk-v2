using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartChangeCustomLineItemPriceModeAction))]
    public partial interface ICartChangeCustomLineItemPriceModeAction : ICartUpdateAction
    {
        string CustomLineItemId { get; set; }

        ICustomLineItemPriceMode Mode { get; set; }

    }
}
