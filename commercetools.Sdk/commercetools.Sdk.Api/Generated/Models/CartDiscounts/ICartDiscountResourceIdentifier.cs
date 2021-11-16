using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountResourceIdentifier))]
    public partial interface ICartDiscountResourceIdentifier : IResourceIdentifier
    {
    }
}
