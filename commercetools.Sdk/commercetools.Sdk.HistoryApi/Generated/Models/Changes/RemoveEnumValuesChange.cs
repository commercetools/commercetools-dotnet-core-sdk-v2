using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveEnumValuesChange : IRemoveEnumValuesChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public string AttributeName { get; set;}
        
        public IEnumValue PreviousValue { get; set;}
        public RemoveEnumValuesChange()
        { 
           this.Type = "RemoveEnumValuesChange";
        }
    }
}
