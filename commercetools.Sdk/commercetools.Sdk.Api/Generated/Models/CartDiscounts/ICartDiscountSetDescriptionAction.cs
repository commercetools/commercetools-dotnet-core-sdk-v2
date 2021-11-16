using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountSetDescriptionAction))]
    public partial interface ICartDiscountSetDescriptionAction : ICartDiscountUpdateAction
    {
        ILocalizedString Description { get; set;}
    }
}
