using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.DiscountCodes
{
    public class DiscountCodeChangeCartDiscountsAction : DiscountCodeUpdateAction
    {
        public List<CartDiscountResourceIdentifier> CartDiscounts { get; set;}
    }
}
