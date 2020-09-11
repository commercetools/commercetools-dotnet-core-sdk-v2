using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CartDiscounts
{
    public class MultiBuyCustomLineItemsTarget : CartDiscountTarget
    {
        public string Predicate { get; set;}
        
        public int TriggerQuantity { get; set;}
        
        public int DiscountedQuantity { get; set;}
        
        public int MaxOccurrence { get; set;}
        
        public SelectionMode SelectionMode { get; set;}
    }
}
