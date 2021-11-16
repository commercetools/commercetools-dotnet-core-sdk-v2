using commercetools.HistoryApi.Models.Common;
using System;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetCustomLineItemCustomFieldChange : ISetCustomLineItemCustomFieldChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string Name { get; set;}
        
        public ILocalizedString CustomLineItem { get; set;}
        
        public Object NextValue { get; set;}
        
        public Object PreviousValue { get; set;}
        public SetCustomLineItemCustomFieldChange()
        { 
           this.Type = "SetCustomLineItemCustomFieldChange";
        }
    }
}
