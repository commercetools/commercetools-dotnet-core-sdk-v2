using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetGeoLocationChange : ISetGeoLocationChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IGeoLocation NextValue { get; set;}
        
        public IGeoLocation PreviousValue { get; set;}
        public SetGeoLocationChange()
        { 
           this.Type = "SetGeoLocationChange";
        }
    }
}
