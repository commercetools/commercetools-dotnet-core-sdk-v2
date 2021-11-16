using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetParcelTrackingDataChange : ISetParcelTrackingDataChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IParcelChangeValue Parcel { get; set;}
        
        public ITrackingData NextValue { get; set;}
        
        public ITrackingData PreviousValue { get; set;}
        public SetParcelTrackingDataChange()
        { 
           this.Type = "SetParcelTrackingDataChange";
        }
    }
}
