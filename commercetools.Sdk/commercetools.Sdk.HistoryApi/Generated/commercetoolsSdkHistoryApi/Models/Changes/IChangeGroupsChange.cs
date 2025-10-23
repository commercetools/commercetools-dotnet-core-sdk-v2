using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.ChangeGroupsChange))]
    public partial interface IChangeGroupsChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        IList<string> PreviousValue { get; set; }

        IEnumerable<string> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<string> NextValue { get; set; }

        IEnumerable<string> NextValueEnumerable { set => NextValue = value.ToList(); }

        IList<string> AddedItems { get; set; }

        IEnumerable<string> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        IList<string> RemovedItems { get; set; }

        IEnumerable<string> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

    }
}
