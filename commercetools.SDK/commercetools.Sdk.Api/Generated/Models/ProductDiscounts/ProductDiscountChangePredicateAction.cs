using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("changePredicate")]
    public partial class ProductDiscountChangePredicateAction : ProductDiscountUpdateAction
    {
        public string Predicate { get; set;}
        public ProductDiscountChangePredicateAction()
        { 
           this.Action = "changePredicate";
        }
    }
}
