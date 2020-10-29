using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    public partial class ProductDiscountChangePredicateAction : IProductDiscountChangePredicateAction
    {
        public string Action { get; set;}
        
        public string Predicate { get; set;}
        public ProductDiscountChangePredicateAction()
        { 
           this.Action = "changePredicate";
        }
    }
}
