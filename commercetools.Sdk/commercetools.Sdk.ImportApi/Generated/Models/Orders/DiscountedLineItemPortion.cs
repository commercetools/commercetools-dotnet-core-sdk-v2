using commercetools.ImportApi.Models.Common;


namespace commercetools.ImportApi.Models.Orders
{
    public partial class DiscountedLineItemPortion : IDiscountedLineItemPortion
    {
        public ICartDiscountKeyReference Discount { get; set; }

        public IMoney DiscountedAmount { get; set; }
    }
}
