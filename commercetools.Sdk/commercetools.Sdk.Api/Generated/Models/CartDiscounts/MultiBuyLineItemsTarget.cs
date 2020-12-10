using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class MultiBuyLineItemsTarget : IMultiBuyLineItemsTarget
    {
        public string Type { get; set;}
        
        public string Predicate { get; set;}
        
        public int TriggerQuantity { get; set;}
        
        public int DiscountedQuantity { get; set;}
        
        public int? MaxOccurrence { get; set;}
        
        public ISelectionMode SelectionMode { get; set;}
        public MultiBuyLineItemsTarget()
        { 
           this.Type = "multiBuyLineItems";
        }
    }
}
