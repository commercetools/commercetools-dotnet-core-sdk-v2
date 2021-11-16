using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveFieldDefinitionChange : IRemoveFieldDefinitionChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IFieldDefinition PreviousValue { get; set;}
        public RemoveFieldDefinitionChange()
        { 
           this.Type = "RemoveFieldDefinitionChange";
        }
    }
}
