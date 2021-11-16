using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountSetDescriptionAction))]
    public partial interface IProductDiscountSetDescriptionAction : IProductDiscountUpdateAction
    {
        ILocalizedString Description { get; set;}
    }
}
