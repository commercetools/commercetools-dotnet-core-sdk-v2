using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("changeCartPredicate")]
    public class CartDiscountChangeCartPredicateAction : CartDiscountUpdateAction
    {
        public string CartPredicate { get; set;}
    }
}
