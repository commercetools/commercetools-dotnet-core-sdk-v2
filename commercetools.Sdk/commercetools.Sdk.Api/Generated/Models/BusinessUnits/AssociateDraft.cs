using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class AssociateDraft : IAssociateDraft
    {
        public IList<IAssociateRoleAssignment> AssociateRoleAssignments { get; set; }
        public IEnumerable<IAssociateRoleAssignment> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        public IList<IAssociateRoleDeprecated> Roles { get; set; }
        public IEnumerable<IAssociateRoleDeprecated> RolesEnumerable { set => Roles = value.ToList(); }


        public ICustomerResourceIdentifier Customer { get; set; }
    }
}
