using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Associate : IAssociate
    {
        public IList<IAssociateRoleAssignment> AssociateRoleAssignments { get; set; }

        public IEnumerable<IAssociateRoleAssignment> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }

        public IList<IAssociateRoleDeprecated> Roles { get; set; }

        public IEnumerable<IAssociateRoleDeprecated> RolesEnumerable { set => Roles = value.ToList(); }

        public ICustomerReference Customer { get; set; }
    }
}
