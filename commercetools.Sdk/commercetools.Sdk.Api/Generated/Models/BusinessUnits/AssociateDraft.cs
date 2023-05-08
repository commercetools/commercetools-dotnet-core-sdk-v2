using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class AssociateDraft : IAssociateDraft
    {
        public IList<IAssociateRoleAssignmentDraft> AssociateRoleAssignments { get; set; }
        public IEnumerable<IAssociateRoleAssignmentDraft> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        [ObsoleteAttribute("This property is obsolete", false)]
        public IList<IAssociateRoleDeprecated> Roles { get; set; }
        [ObsoleteAttribute("This property is obsolete", false)]
        public IEnumerable<IAssociateRoleDeprecated> RolesEnumerable { set => Roles = value.ToList(); }


        public ICustomerResourceIdentifier Customer { get; set; }
    }
}
