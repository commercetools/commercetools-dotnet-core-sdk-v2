using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.ImportApi.Models.BusinessUnits
{

    public partial class AssociateDraft : IAssociateDraft
    {
        public ICustomerKeyReference Customer { get; set; }

        public IList<IAssociateRoleAssignmentDraft> AssociateRoleAssignments { get; set; }

        public IEnumerable<IAssociateRoleAssignmentDraft> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }
    }
}
