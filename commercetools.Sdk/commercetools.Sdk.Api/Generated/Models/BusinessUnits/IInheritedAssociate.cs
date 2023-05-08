using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.InheritedAssociate))]
    public partial interface IInheritedAssociate
    {
        IList<IInheritedAssociateRoleAssignment> AssociateRoleAssignments { get; set; }
        IEnumerable<IInheritedAssociateRoleAssignment> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        ICustomerReference Customer { get; set; }

    }
}
