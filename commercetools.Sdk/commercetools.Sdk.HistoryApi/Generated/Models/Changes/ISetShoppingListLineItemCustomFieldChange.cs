using commercetools.HistoryApi.Models.ChangeValues;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetShoppingListLineItemCustomFieldChange))]
    public partial interface ISetShoppingListLineItemCustomFieldChange : IChange
    {
        new string Type { get; set;}
        
        new string Change { get; set;}
        
        string Name { get; set;}
        
        string CustomTypeId { get; set;}
        
        IShoppingListLineItemValue LineItem { get; set;}
        
        Object NextValue { get; set;}
        
        Object PreviousValue { get; set;}
    }
}
