using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
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

        IList<IReservation> AddedItems { get; set; }

        IEnumerable<IReservation> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        IList<IReservation> RemovedItems { get; set; }

        IEnumerable<IReservation> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

    }
}
