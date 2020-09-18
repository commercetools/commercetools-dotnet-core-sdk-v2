using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("multiBuyLineItems")]
    public class MultiBuyLineItemsTarget : CartDiscountTarget
    {
        public string Predicate { get; set;}
        
        public int TriggerQuantity { get; set;}
        
        public int DiscountedQuantity { get; set;}
        
        public int MaxOccurrence { get; set;}
        
        public string SelectionMode { get; set;}
        
        public SelectionMode SelectionModeAsEnum => this.SelectionMode.GetEnum<SelectionMode>();
    }
}
