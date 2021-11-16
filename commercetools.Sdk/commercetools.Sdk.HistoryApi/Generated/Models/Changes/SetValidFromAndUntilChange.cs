using commercetools.HistoryApi.Models.ChangeValues;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetValidFromAndUntilChange : ISetValidFromAndUntilChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IValidFromAndUntilValue PreviousValue { get; set;}
        
        public IValidFromAndUntilValue NextValue { get; set;}
        public SetValidFromAndUntilChange()
        { 
           this.Type = "SetValidFromAndUntilChange";
        }
    }
}
