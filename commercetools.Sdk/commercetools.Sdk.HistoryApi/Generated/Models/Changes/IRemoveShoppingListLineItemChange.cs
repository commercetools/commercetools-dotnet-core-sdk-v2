using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemoveShoppingListLineItemChange))]
    public partial interface IRemoveShoppingListLineItemChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        ILineItem PreviousValue { get; set;}
        
        ILineItem NextValue { get; set;}
    }
}
