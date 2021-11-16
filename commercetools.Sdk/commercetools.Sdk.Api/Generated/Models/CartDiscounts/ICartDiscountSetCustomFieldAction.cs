using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountSetCustomFieldAction))]
    public partial interface ICartDiscountSetCustomFieldAction : ICartDiscountUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
