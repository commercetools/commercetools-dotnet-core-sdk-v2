using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("changeCartDiscounts")]
    public class DiscountCodeChangeCartDiscountsAction : DiscountCodeUpdateAction
    {
        public List<CartDiscountResourceIdentifier> CartDiscounts { get; set;}
    }
}
