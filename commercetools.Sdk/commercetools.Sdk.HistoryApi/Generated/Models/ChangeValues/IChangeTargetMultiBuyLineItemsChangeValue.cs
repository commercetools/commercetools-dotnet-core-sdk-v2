using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.ChangeValues
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.ChangeValues.ChangeTargetMultiBuyLineItemsChangeValue))]
    public partial interface IChangeTargetMultiBuyLineItemsChangeValue : IChangeTargetChangeValue
    {
        new string Type { get; set;}
        
        string Predicate { get; set;}
        
        int TriggerQuantity { get; set;}
        
        int DiscountedQuantity { get; set;}
        
        int MaxOccurrence { get; set;}
        
        ISelectionMode SelectionMode { get; set;}
    }
}
