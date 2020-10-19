using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("changeCartPredicate")]
    public partial class CartDiscountChangeCartPredicateAction : CartDiscountUpdateAction
    {
        public string CartPredicate { get; set;}
        public CartDiscountChangeCartPredicateAction()
        { 
           this.Action = "changeCartPredicate";
        }
    }
}
