using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


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
