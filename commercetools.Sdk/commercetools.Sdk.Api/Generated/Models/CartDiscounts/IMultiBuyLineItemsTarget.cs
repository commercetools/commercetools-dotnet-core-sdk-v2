using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.CartDiscounts.MultiBuyLineItemsTarget))]
    public interface IMultiBuyLineItemsTarget : ICartDiscountTarget
    {
        string Predicate { get; set;}
        
        int TriggerQuantity { get; set;}
        
        int DiscountedQuantity { get; set;}
        
        int? MaxOccurrence { get; set;}
        
        string SelectionMode { get; set;}
        
        SelectionMode SelectionModeAsEnum { get; }
    }
}
