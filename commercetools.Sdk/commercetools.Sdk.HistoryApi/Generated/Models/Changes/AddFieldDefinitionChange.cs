using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddFieldDefinitionChange : IAddFieldDefinitionChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IFieldDefinition NextValue { get; set;}
        public AddFieldDefinitionChange()
        { 
           this.Type = "AddFieldDefinitionChange";
        }
    }
}
