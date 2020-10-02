using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("customLineItems")]
    public partial class CartDiscountCustomLineItemsTarget : CartDiscountTarget
    {
        public string Predicate { get; set;}
        public CartDiscountCustomLineItemsTarget()
        { 
           this.Type = "customLineItems";
        }
    }
}
