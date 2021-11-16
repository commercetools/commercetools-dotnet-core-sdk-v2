using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetCustomFieldChange))]
    public partial interface ISetCustomFieldChange : IChange
    {
        new string Change { get; set;}
        
        new string Type { get; set;}
        
        string Name { get; set;}
        
        string CustomTypeId { get; set;}
        
        Object NextValue { get; set;}
        
        Object PreviousValue { get; set;}
    }
}
