using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    public class CartDiscountChangeTargetAction : CartDiscountUpdateAction
    {
        public CartDiscountTarget Target { get; set;}
    }
}
