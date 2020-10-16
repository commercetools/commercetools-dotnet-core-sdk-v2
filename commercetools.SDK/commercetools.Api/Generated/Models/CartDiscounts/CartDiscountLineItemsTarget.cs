using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("lineItems")]
    public partial class CartDiscountLineItemsTarget : CartDiscountTarget
    {
        public string Predicate { get; set;}
        public CartDiscountLineItemsTarget()
        { 
           this.Type = "lineItems";
        }
    }
}
