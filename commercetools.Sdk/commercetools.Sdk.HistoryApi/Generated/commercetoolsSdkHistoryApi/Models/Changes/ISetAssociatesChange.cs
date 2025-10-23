using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetAssociatesChange))]
    public partial interface ISetAssociatesChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IList<IAssociate> AddedItems { get; set; }

        IEnumerable<IAssociate> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        IList<IAssociate> RemovedItems { get; set; }

        IEnumerable<IAssociate> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

        IList<IAssociate> PreviousValue { get; set; }

        IEnumerable<IAssociate> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<IAssociate> NextValue { get; set; }

        IEnumerable<IAssociate> NextValueEnumerable { set => NextValue = value.ToList(); }

    }
}
