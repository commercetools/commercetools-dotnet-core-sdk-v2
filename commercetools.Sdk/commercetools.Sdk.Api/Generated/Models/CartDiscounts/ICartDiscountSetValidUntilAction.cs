using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.CartDiscounts.CartDiscountSetValidUntilAction))]
    public partial interface ICartDiscountSetValidUntilAction : ICartDiscountUpdateAction
    {
        DateTime? ValidUntil { get; set; }

    }
}
