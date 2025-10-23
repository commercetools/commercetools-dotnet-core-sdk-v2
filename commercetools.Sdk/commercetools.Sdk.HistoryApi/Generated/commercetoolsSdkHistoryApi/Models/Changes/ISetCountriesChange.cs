using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCountriesChange))]
    public partial interface ISetCountriesChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IStoreCountry> PreviousValue { get; set; }

        IEnumerable<IStoreCountry> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<IStoreCountry> NextValue { get; set; }

        IEnumerable<IStoreCountry> NextValueEnumerable { set => NextValue = value.ToList(); }

        IList<IStoreCountry> AddedItems { get; set; }

        IEnumerable<IStoreCountry> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        IList<IStoreCountry> RemovedItems { get; set; }

        IEnumerable<IStoreCountry> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

    }
}
