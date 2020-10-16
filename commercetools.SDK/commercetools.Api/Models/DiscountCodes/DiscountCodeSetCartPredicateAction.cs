using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setCartPredicate")]
    public partial class DiscountCodeSetCartPredicateAction : DiscountCodeUpdateAction
    {
        public string CartPredicate { get; set;}
        public DiscountCodeSetCartPredicateAction()
        { 
           this.Action = "setCartPredicate";
        }
    }
}
