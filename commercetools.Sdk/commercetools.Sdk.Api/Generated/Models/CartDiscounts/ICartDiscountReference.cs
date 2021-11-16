using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountReference))]
    public partial interface ICartDiscountReference : IReference
    {
        ICartDiscount Obj { get; set; }
    }
}
