namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class DiscountedLineItemPriceForQuantity : IDiscountedLineItemPriceForQuantity
    {
        public long Quantity { get; set; }

        public IDiscountedLineItemPrice DiscountedPrice { get; set; }
    }
}
