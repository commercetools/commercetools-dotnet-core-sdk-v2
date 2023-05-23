using commercetools.Sdk.Api.Models.BusinessUnits;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyBusinessUnitAssociateDraft))]
    public partial interface IMyBusinessUnitAssociateDraft
    {
        long Version { get; set; }

        IMyCustomerDraft Customer { get; set; }

        IList<IAssociateRoleAssignmentDraft> AssociateRoleAssignments { get; set; }
        IEnumerable<IAssociateRoleAssignmentDraft> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


    }
}
