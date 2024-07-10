using commercetools.Sdk.HistoryApi.Models.ChangeValues;
using commercetools.Sdk.HistoryApi.Models.Changes;
using commercetools.Sdk.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetParcelTrackingDataChange : ISetParcelTrackingDataChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITrackingData PreviousValue { get; set; }

        public ITrackingData NextValue { get; set; }

        public IParcelChangeValue Parcel { get; set; }
        public SetParcelTrackingDataChange()
        {
            this.Type = "SetParcelTrackingDataChange";
        }
    }
}
