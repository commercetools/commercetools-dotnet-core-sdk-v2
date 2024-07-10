using commercetools.Sdk.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CartDiscounts
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
