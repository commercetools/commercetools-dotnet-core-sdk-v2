using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddLocationChange : IAddLocationChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public ILocation PreviousValue { get; set;}
        
        public ILocation NextValue { get; set;}
        public AddLocationChange()
        { 
           this.Type = "AddLocationChange";
        }
    }
}
