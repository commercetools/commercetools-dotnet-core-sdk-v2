using commercetools.Api.Models.CartDiscounts;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Api.Models.DiscountCodes.DiscountCodeChangeCartDiscountsAction))]
    public partial interface IDiscountCodeChangeCartDiscountsAction : IDiscountCodeUpdateAction
    {
        List<ICartDiscountResourceIdentifier> CartDiscounts { get; set; }
    }
}
