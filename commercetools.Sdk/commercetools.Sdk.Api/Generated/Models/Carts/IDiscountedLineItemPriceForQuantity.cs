using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.DiscountedLineItemPriceForQuantity))]
    public partial interface IDiscountedLineItemPriceForQuantity
    {
        decimal Quantity { get; set; }

        IDiscountedLineItemPrice DiscountedPrice { get; set; }
    }
}
