using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.HistoryApi.Models.Changes
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
