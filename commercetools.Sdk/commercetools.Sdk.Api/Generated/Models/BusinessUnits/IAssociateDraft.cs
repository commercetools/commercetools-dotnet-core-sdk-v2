using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.AssociateDraft))]
    public partial interface IAssociateDraft
    {
        IList<IAssociateRoleAssignmentDraft> AssociateRoleAssignments { get; set; }
        IEnumerable<IAssociateRoleAssignmentDraft> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        [ObsoleteAttribute("This property is obsolete", false)]
        IList<IAssociateRoleDeprecated> Roles { get; set; }
        [ObsoleteAttribute("This property is obsolete", false)]
        IEnumerable<IAssociateRoleDeprecated> RolesEnumerable { set => Roles = value.ToList(); }


        ICustomerResourceIdentifier Customer { get; set; }

    }
}
