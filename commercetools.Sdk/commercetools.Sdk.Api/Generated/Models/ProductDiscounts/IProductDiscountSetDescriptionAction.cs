using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductDiscounts.ProductDiscountSetDescriptionAction))]
    public partial interface IProductDiscountSetDescriptionAction : IProductDiscountUpdateAction
    {
        ILocalizedString Description { get; set; }
    }
}
