using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.Associate))]
    public partial interface IAssociate
    {
        IList<IAssociateRoleAssignment> AssociateRoleAssignments { get; set; }
        IEnumerable<IAssociateRoleAssignment> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        IList<IAssociateRoleDeprecated> Roles { get; set; }
        IEnumerable<IAssociateRoleDeprecated> RolesEnumerable { set => Roles = value.ToList(); }


        ICustomerReference Customer { get; set; }

    }
}
