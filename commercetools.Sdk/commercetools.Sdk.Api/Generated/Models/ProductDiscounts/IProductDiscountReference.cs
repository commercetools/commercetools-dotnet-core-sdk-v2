using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountReference))]
    public partial interface IProductDiscountReference : IReference
    {
        IProductDiscount Obj { get; set;}
    }
}
