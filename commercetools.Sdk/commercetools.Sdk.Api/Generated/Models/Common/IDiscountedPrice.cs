using commercetools.Api.Models.ProductDiscounts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.DiscountedPrice))]
    public partial interface IDiscountedPrice
    {
        ITypedMoney Value { get; set; }

        IProductDiscountReference Discount { get; set; }
    }
}
