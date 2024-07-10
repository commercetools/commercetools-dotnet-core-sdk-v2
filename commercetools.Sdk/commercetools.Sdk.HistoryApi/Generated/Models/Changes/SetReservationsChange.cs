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

    public partial class SetReservationsChange : ISetReservationsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IReservation> PreviousValue { get; set; }
        public IEnumerable<IReservation> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        public IList<IReservation> NextValue { get; set; }
        public IEnumerable<IReservation> NextValueEnumerable { set => NextValue = value.ToList(); }

        public SetReservationsChange()
        {
            this.Type = "SetReservationsChange";
        }
    }
}
