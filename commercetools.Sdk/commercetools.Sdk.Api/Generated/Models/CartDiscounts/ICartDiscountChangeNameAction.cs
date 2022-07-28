using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountChangeNameAction))]
    public partial interface ICartDiscountChangeNameAction : ICartDiscountUpdateAction
    {
        ILocalizedString Name { get; set; }

    }
}
