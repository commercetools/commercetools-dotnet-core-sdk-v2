using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitSetCustomerGroupAssignmentsAction : IBusinessUnitSetCustomerGroupAssignmentsAction
    {
        public string Action { get; set; }

        public IList<ICustomerGroupAssignmentDraft> CustomerGroupAssignments { get; set; }

        public IEnumerable<ICustomerGroupAssignmentDraft> CustomerGroupAssignmentsEnumerable { set => CustomerGroupAssignments = value.ToList(); }
        public BusinessUnitSetCustomerGroupAssignmentsAction()
        {
            this.Action = "setCustomerGroupAssignments";
        }
    }
}
