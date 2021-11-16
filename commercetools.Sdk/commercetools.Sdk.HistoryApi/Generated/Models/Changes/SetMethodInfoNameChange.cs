using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetMethodInfoNameChange : ISetMethodInfoNameChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ILocalizedString PreviousValue { get; set;}
        
        public ILocalizedString NextValue { get; set;}
        public SetMethodInfoNameChange()
        { 
           this.Type = "SetMethodInfoNameChange";
        }
    }
}
