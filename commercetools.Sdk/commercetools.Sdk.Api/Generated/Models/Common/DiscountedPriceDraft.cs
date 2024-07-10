using commercetools.Sdk.Api.Models.ProductDiscounts;


namespace commercetools.Sdk.Api.Models.Common
{

    public partial class DiscountedPriceDraft : IDiscountedPriceDraft
    {
        public IMoney Value { get; set; }

        public IProductDiscountReference Discount { get; set; }
    }
}
