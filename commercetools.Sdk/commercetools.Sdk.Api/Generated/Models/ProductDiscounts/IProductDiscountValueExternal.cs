using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountValueExternal))]
    public partial interface IProductDiscountValueExternal : IProductDiscountValue
    {
    }
}
