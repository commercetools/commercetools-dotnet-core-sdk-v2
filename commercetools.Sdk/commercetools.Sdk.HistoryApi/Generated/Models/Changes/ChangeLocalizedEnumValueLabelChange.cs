using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeLocalizedEnumValueLabelChange : IChangeLocalizedEnumValueLabelChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string FieldName { get; set;}
        
        public string AttributeName { get; set;}
        
        public string ValueKey { get; set;}
        
        public ILocalizedString PreviousValue { get; set;}
        
        public ILocalizedString NextValue { get; set;}
        public ChangeLocalizedEnumValueLabelChange()
        { 
           this.Type = "ChangeLocalizedEnumValueLabelChange";
        }
    }
}
