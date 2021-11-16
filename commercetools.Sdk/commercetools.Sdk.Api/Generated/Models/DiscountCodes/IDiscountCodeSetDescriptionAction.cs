using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeSetDescriptionAction))]
    public partial interface IDiscountCodeSetDescriptionAction : IDiscountCodeUpdateAction
    {
        ILocalizedString Description { get; set;}
    }
}
