using commercetools.Sdk.HistoryApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Changes
{

    public partial class SetCustomerGroupAssignmentsChange : ISetCustomerGroupAssignmentsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IList<ICustomerGroupAssignment> AddedItems { get; set; }

        public IEnumerable<ICustomerGroupAssignment> AddedItemsEnumerable { set => AddedItems = value.ToList(); }

        public IList<ICustomerGroupAssignment> RemovedItems { get; set; }

        public IEnumerable<ICustomerGroupAssignment> RemovedItemsEnumerable { set => RemovedItems = value.ToList(); }

        public IList<ICustomerGroupAssignment> PreviousValue { get; set; }

        public IEnumerable<ICustomerGroupAssignment> PreviousValueEnumerable { set => PreviousValue = value.ToList(); }

        public IList<ICustomerGroupAssignment> NextValue { get; set; }

        public IEnumerable<ICustomerGroupAssignment> NextValueEnumerable { set => NextValue = value.ToList(); }
        public SetCustomerGroupAssignmentsChange()
        {
            this.Type = "SetCustomerGroupAssignmentsChange";
        }
    }
}
