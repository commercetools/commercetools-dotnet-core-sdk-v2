using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetReservationsChange : ISetReservationsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<IReservation> NextValue { get; set; }
        public IEnumerable<IReservation> NextValueEnumerable { set => NextValue = value.ToList(); }


        public IList<IReservation> PreviousValue { get; set; }
        public IEnumerable<IReservation> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public SetReservationsChange()
        {
            this.Type = "SetReservationsChange";
        }
    }
}
