using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    public class CartDiscountChangeValueAction : CartDiscountUpdateAction
    {
        public CartDiscountValueDraft Value { get; set;}
    }
}
