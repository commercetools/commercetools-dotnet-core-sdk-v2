using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeValueChange : IChangeValueChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IChangeValueChangeValue NextValue { get; set;}
        
        public IChangeValueChangeValue PreviousValue { get; set;}
        public ChangeValueChange()
        { 
           this.Type = "ChangeValueChange";
        }
    }
}
