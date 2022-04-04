using commercetools.Sdk.Api.Models.CartDiscounts;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.DiscountCodes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.DiscountCodes.DiscountCodeChangeCartDiscountsAction))]
    public partial interface IDiscountCodeChangeCartDiscountsAction : IDiscountCodeUpdateAction
    {
        List<ICartDiscountResourceIdentifier> CartDiscounts { get; set; }
    }
}
