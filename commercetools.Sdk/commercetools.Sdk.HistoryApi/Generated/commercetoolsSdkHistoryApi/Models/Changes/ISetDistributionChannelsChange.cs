using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetDistributionChannelsChange))]
    public partial interface ISetDistributionChannelsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<IReference> PreviousValue { get; set; }

        IEnumerable<IReference> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<IReference> NextValue { get; set; }

        IEnumerable<IReference> NextValueEnumerable { set => NextValue = value.ToList(); }

        IList<IReference> AddedItems { get; set; }

        IEnumerable<IReference> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        IList<IReference> RemovedItems { get; set; }

        IEnumerable<IReference> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

    }
}
