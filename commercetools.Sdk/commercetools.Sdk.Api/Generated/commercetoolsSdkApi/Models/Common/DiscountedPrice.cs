using commercetools.Sdk.Api.Models.ProductDiscounts;


namespace commercetools.Sdk.Api.Models.Common
{

    public partial class DiscountedPrice : IDiscountedPrice
    {
        public ITypedMoney Value { get; set; }

        public IProductDiscountReference Discount { get; set; }
    }
}
