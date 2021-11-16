using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangePlainEnumValueOrderChange : IChangePlainEnumValueOrderChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string AttributeName { get; set;}
        
        public List<IEnumValue> NextValue { get; set;}
        
        public List<IEnumValue> PreviousValue { get; set;}
        public ChangePlainEnumValueOrderChange()
        { 
           this.Type = "ChangePlainEnumValueOrderChange";
        }
    }
}
