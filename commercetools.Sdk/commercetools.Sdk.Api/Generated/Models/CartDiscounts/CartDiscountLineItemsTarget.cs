using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountLineItemsTarget : ICartDiscountLineItemsTarget
    {
        public string Type { get; set;}
        
        public string Predicate { get; set;}
        public CartDiscountLineItemsTarget()
        { 
           this.Type = "lineItems";
        }
    }
}
