using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountCustomLineItemsTarget : ICartDiscountCustomLineItemsTarget
    {
        public string Type { get; set;}
        
        public string Predicate { get; set;}
        public CartDiscountCustomLineItemsTarget()
        { 
           this.Type = "customLineItems";
        }
    }
}
