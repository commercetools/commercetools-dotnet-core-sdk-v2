using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetReservationsChange))]
    public partial interface ISetReservationsChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IList<IReservation> PreviousValue { get; set; }
        IEnumerable<IReservation> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }


        IList<IReservation> NextValue { get; set; }
        IEnumerable<IReservation> NextValueEnumerable { set => NextValue = value.ToList(); }


    }
}
