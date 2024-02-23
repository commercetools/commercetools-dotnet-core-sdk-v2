using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.AssociateDraft))]
    public partial interface IAssociateDraft
    {
        IList<IAssociateRoleAssignmentDraft> AssociateRoleAssignments { get; set; }
        IEnumerable<IAssociateRoleAssignmentDraft> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        ICustomerResourceIdentifier Customer { get; set; }

    }
}
