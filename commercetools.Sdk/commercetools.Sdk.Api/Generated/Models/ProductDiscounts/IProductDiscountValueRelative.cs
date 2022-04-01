using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountValueRelative))]
    public partial interface IProductDiscountValueRelative : IProductDiscountValue
    {
        long Permyriad { get; set; }
    }
}
