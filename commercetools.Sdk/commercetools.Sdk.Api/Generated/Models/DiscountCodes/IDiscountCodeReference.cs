using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeReference))]
    public partial interface IDiscountCodeReference : IReference
    {
        IDiscountCode Obj { get; set; }
    }
}
