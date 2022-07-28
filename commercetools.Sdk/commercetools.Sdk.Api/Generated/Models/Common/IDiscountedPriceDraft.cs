using commercetools.Sdk.Api.Models.ProductDiscounts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Common.DiscountedPriceDraft))]
    public partial interface IDiscountedPriceDraft
    {
        IMoney Value { get; set; }

        IProductDiscountReference Discount { get; set; }

    }
}
