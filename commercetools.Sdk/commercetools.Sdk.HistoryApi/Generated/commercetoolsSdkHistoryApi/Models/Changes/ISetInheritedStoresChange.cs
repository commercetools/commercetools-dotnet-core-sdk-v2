using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetInheritedStoresChange))]
    public partial interface ISetInheritedStoresChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IList<IKeyReference> AddedItems { get; set; }

        IEnumerable<IKeyReference> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        IList<IKeyReference> RemovedItems { get; set; }

        IEnumerable<IKeyReference> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

        IList<IKeyReference> PreviousValue { get; set; }

        IEnumerable<IKeyReference> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<IKeyReference> NextValue { get; set; }

        IEnumerable<IKeyReference> NextValueEnumerable { set => NextValue = value.ToList(); }

    }
}
