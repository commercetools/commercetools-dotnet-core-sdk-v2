using commercetools.Api.Models.ProductDiscounts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.DiscountedPriceDraft))]
    public partial interface IDiscountedPriceDraft 
    {
        IMoney Value { get; set;}
        
        IProductDiscountReference Discount { get; set;}
    }
}
