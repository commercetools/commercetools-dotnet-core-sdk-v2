using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetDescriptionAction))]
    public partial interface ICartDiscountSetDescriptionAction : ICartDiscountUpdateAction
    {
        ILocalizedString Description { get; set; }

    }
}
