using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountChangeNameAction))]
    public partial interface ICartDiscountChangeNameAction : ICartDiscountUpdateAction
    {
        ILocalizedString Name { get; set;}
    }
}
