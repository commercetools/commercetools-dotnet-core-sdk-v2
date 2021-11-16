using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountSetValidUntilAction))]
    public partial interface ICartDiscountSetValidUntilAction : ICartDiscountUpdateAction
    {
        DateTime? ValidUntil { get; set;}
    }
}
