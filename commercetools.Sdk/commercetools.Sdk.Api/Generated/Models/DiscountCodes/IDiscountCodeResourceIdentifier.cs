using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeResourceIdentifier))]
    public partial interface IDiscountCodeResourceIdentifier : IResourceIdentifier
    {
    }
}
