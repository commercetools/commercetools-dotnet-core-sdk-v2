using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeTargetChange : IChangeTargetChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IChangeTargetChangeValue NextValue { get; set;}
        
        public IChangeTargetChangeValue PreviousValue { get; set;}
        public ChangeTargetChange()
        { 
           this.Type = "ChangeTargetChange";
        }
    }
}
