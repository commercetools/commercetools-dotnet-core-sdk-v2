using commercetools.Sdk.ImportApi.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.BusinessUnits.AssociateDraft))]
    public partial interface IAssociateDraft
    {
        ICustomerKeyReference Customer { get; set; }

        IList<IAssociateRoleAssignmentDraft> AssociateRoleAssignments { get; set; }

        IEnumerable<IAssociateRoleAssignmentDraft> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }

    }
}
