using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountChangeNameAction))]
    public partial interface IProductDiscountChangeNameAction : IProductDiscountUpdateAction
    {
        ILocalizedString Name { get; set; }
    }
}
