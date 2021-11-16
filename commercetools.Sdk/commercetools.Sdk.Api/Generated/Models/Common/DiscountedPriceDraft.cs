using commercetools.Api.Models.ProductDiscounts;


namespace commercetools.Api.Models.Common
{
    public partial class DiscountedPriceDraft : IDiscountedPriceDraft
    {
        public IMoney Value { get; set; }

        public IProductDiscountReference Discount { get; set; }
    }
}
