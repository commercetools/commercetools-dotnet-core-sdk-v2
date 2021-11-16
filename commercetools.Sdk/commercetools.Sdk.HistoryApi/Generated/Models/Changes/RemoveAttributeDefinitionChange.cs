using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveAttributeDefinitionChange : IRemoveAttributeDefinitionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAttributeDefinition PreviousValue { get; set; }
        public RemoveAttributeDefinitionChange()
        {
            this.Type = "RemoveAttributeDefinitionChange";
        }
    }
}
