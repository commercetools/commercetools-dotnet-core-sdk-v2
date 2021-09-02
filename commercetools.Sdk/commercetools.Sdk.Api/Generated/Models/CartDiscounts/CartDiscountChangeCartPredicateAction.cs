using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountChangeCartPredicateAction : ICartDiscountChangeCartPredicateAction
    {
        public string Action { get; set; }

        public string CartPredicate { get; set; }
        public CartDiscountChangeCartPredicateAction()
        {
            this.Action = "changeCartPredicate";
        }
    }
}
