namespace commercetools.HistoryApi.Models.Common
{
    public partial class DiscountedLineItemPortion : IDiscountedLineItemPortion
    {
        public IReference Discount { get; set; }

        public IMoney DiscountedAmount { get; set; }
    }
}
