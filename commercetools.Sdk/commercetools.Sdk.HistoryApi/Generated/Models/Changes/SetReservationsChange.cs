using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetReservationsChange : ISetReservationsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public List<IReservation> NextValue { get; set; }

        public List<IReservation> PreviousValue { get; set; }
        public SetReservationsChange()
        {
            this.Type = "SetReservationsChange";
        }
    }
}
