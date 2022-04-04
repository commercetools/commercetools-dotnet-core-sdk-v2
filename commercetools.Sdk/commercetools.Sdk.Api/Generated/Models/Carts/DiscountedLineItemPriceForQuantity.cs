namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class DiscountedLineItemPriceForQuantity : IDiscountedLineItemPriceForQuantity
    {
        public double Quantity { get; set; }

        public IDiscountedLineItemPrice DiscountedPrice { get; set; }
    }
}
