using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class InheritedAssociate : IInheritedAssociate
    {
        public IList<IInheritedAssociateRoleAssignment> AssociateRoleAssignments { get; set; }
        public IEnumerable<IInheritedAssociateRoleAssignment> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        public ICustomerReference Customer { get; set; }
    }
}
