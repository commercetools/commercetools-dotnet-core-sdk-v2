using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountSetValidFromAction))]
    public partial interface ICartDiscountSetValidFromAction : ICartDiscountUpdateAction
    {
        DateTime? ValidFrom { get; set;}
    }
}
