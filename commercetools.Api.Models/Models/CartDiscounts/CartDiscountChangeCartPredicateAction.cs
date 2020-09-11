using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    public class CartDiscountChangeCartPredicateAction : CartDiscountUpdateAction
    {
        public string CartPredicate { get; set;}
    }
}
