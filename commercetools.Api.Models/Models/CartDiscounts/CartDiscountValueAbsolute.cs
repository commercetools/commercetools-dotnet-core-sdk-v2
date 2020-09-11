using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    public class CartDiscountValueAbsolute : CartDiscountValue
    {
        public List<TypedMoney> Money { get; set;}
    }
}
