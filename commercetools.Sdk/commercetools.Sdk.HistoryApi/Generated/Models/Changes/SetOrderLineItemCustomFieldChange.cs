using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetOrderLineItemCustomFieldChange : ISetOrderLineItemCustomFieldChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string CustomTypeId { get; set;}
        
        public string Name { get; set;}
        
        public string Variant { get; set;}
        
        public ILocalizedString LineItem { get; set;}
        
        public Object NextValue { get; set;}
        
        public Object PreviousValue { get; set;}
        public SetOrderLineItemCustomFieldChange()
        { 
           this.Type = "SetOrderLineItemCustomFieldChange";
        }
    }
}
