using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountResourceIdentifier))]
    public partial interface IProductDiscountResourceIdentifier : IResourceIdentifier
    {
    }
}
