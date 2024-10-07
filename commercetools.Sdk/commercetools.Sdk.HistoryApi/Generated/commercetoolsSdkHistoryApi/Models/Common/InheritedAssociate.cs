using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class InheritedAssociate : IInheritedAssociate
    {
        public IList<IInheritedAssociateRoleAssignment> AssociateRoleAssignments { get; set; }

        public IEnumerable<IInheritedAssociateRoleAssignment> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }

        public IReference Customer { get; set; }
    }
}
