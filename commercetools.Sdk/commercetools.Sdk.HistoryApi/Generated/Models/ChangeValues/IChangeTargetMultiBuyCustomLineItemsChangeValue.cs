using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeTargetMultiBuyCustomLineItemsChangeValue))]
    public partial interface IChangeTargetMultiBuyCustomLineItemsChangeValue : IChangeTargetChangeValue
    {
        new string Type { get; set;}
        
        string Predicate { get; set;}
        
        int TriggerQuantity { get; set;}
        
        int DiscountedQuantity { get; set;}
        
        int MaxOccurrence { get; set;}
        
        ISelectionMode SelectionMode { get; set;}
    }
}
