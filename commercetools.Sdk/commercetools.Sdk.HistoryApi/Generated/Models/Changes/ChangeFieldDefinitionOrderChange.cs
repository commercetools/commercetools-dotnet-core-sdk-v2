using commercetools.HistoryApi.Models.ChangeValues;
using System.Collections.Generic;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeFieldDefinitionOrderChange : IChangeFieldDefinitionOrderChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public List<IFieldDefinitionOrderValue> PreviousValue { get; set;}
        
        public List<IFieldDefinitionOrderValue> NextValue { get; set;}
        public ChangeFieldDefinitionOrderChange()
        { 
           this.Type = "ChangeFieldDefinitionOrderChange";
        }
    }
}
