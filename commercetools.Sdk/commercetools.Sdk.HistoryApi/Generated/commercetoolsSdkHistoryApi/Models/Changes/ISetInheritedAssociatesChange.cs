using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetInheritedAssociatesChange))]
    public partial interface ISetInheritedAssociatesChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IList<IInheritedAssociate> AddedItems { get; set; }

        IEnumerable<IInheritedAssociate> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        IList<IInheritedAssociate> RemovedItems { get; set; }

        IEnumerable<IInheritedAssociate> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

        IList<IInheritedAssociate> PreviousValue { get; set; }

        IEnumerable<IInheritedAssociate> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<IInheritedAssociate> NextValue { get; set; }

        IEnumerable<IInheritedAssociate> NextValueEnumerable { set => NextValue = value.ToList(); }

    }
}
