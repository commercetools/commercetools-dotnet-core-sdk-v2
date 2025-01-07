using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerGroupAssignmentsSetMessagePayload : ICustomerGroupAssignmentsSetMessagePayload
    {
        public string Type { get; set; }

        public IList<ICustomerGroupAssignment> CustomerGroupAssignments { get; set; }

        public IEnumerable<ICustomerGroupAssignment> CustomerGroupAssignmentsEnumerable { set => CustomerGroupAssignments = value.ToList(); }
        public CustomerGroupAssignmentsSetMessagePayload()
        {
            this.Type = "CustomerGroupAssignmentsSet";
        }
    }
}
