using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    public class CartDiscountSetValidFromAction : CartDiscountUpdateAction
    {
        public DateTime ValidFrom { get; set;}
    }
}
