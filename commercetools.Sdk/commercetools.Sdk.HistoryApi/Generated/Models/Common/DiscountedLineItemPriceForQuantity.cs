namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class DiscountedLineItemPriceForQuantity : IDiscountedLineItemPriceForQuantity
    {
        public int Quantity { get; set; }

        public IDiscountedLineItemPrice DiscountedPrice { get; set; }
    }
}
