using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Changes.SetCustomerGroupAssignmentsChange))]
    public partial interface ISetCustomerGroupAssignmentsChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        IList<ICustomerGroupAssignment> AddedItems { get; set; }

        IEnumerable<ICustomerGroupAssignment> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        IList<ICustomerGroupAssignment> RemovedItems { get; set; }

        IEnumerable<ICustomerGroupAssignment> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

        IList<ICustomerGroupAssignment> PreviousValue { get; set; }

        IEnumerable<ICustomerGroupAssignment> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        IList<ICustomerGroupAssignment> NextValue { get; set; }

        IEnumerable<ICustomerGroupAssignment> NextValueEnumerable { set => NextValue = value.ToList(); }

    }
}
