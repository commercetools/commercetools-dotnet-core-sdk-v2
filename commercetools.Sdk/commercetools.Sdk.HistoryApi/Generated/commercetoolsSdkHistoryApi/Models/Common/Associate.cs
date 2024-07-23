using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.HistoryApi.Models.Common
{

    public partial class Associate : IAssociate
    {
        public IList<IAssociateRoleAssignment> AssociateRoleAssignments { get; set; }
        public IEnumerable<IAssociateRoleAssignment> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        public IReference Customer { get; set; }
    }
}
