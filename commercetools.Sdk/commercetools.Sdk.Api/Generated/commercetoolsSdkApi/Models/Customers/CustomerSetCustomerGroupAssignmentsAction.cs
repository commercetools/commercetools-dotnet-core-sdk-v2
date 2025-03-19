using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetCustomerGroupAssignmentsAction : ICustomerSetCustomerGroupAssignmentsAction
    {
        public string Action { get; set; }

        public IList<ICustomerGroupAssignmentDraft> CustomerGroupAssignments { get; set; }

        public IEnumerable<ICustomerGroupAssignmentDraft> CustomerGroupAssignmentsEnumerable { set => CustomerGroupAssignments = value.ToList(); }
        public CustomerSetCustomerGroupAssignmentsAction()
        {
            this.Action = "setCustomerGroupAssignments";
        }
    }
}
