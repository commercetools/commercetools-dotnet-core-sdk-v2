using commercetools.Sdk.Api.Models.BusinessUnits;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyBusinessUnitAssociateDraft : IMyBusinessUnitAssociateDraft
    {
        public long Version { get; set; }

        public IMyCustomerDraft Customer { get; set; }

        public IList<IAssociateRoleAssignmentDraft> AssociateRoleAssignments { get; set; }
        public IEnumerable<IAssociateRoleAssignmentDraft> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }

    }
}
