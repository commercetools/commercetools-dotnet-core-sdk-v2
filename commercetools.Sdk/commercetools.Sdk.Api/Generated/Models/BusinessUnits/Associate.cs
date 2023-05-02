using commercetools.Sdk.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class Associate : IAssociate
    {
        public IList<IAssociateRoleAssignment> AssociateRoleAssignments { get; set; }
        public IEnumerable<IAssociateRoleAssignment> AssociateRoleAssignmentsEnumerable { set => AssociateRoleAssignments = value.ToList(); }


        [ObsoleteAttribute("This property is obsolete", false)]
        public IList<IAssociateRoleDeprecated> Roles { get; set; }
        [ObsoleteAttribute("This property is obsolete", false)]
        public IEnumerable<IAssociateRoleDeprecated> RolesEnumerable { set => Roles = value.ToList(); }


        public ICustomerReference Customer { get; set; }
    }
}
