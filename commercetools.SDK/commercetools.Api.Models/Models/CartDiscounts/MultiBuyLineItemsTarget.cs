using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("multiBuyLineItems")]
    public partial class MultiBuyLineItemsTarget : CartDiscountTarget
    {
        public string Predicate { get; set;}
        
        public int TriggerQuantity { get; set;}
        
        public int DiscountedQuantity { get; set;}
        
        public int MaxOccurrence { get; set;}
        
        public string SelectionMode { get; set;}
        
        [JsonIgnore]
        public SelectionMode SelectionModeAsEnum => this.SelectionMode.GetEnum<SelectionMode>();
        public MultiBuyLineItemsTarget()
        { 
           this.Type = "multiBuyLineItems";
        }
    }
}
