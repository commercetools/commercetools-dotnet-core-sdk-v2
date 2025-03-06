using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.BusinessUnits
{

    public partial class BusinessUnitAssociateResponse : IBusinessUnitAssociateResponse
    {
        public ICustomerReference Customer { get; set; }

        public IList<IAssociateRole> AssociateRoles { get; set; }

        public IEnumerable<IAssociateRole> AssociateRolesEnumerable { set => AssociateRoles = value.ToList(); }

        public IList<IAssociateRole> InheritedAssociateRoles { get; set; }

        public IEnumerable<IAssociateRole> InheritedAssociateRolesEnumerable { set => InheritedAssociateRoles = value.ToList(); }

        public IList<IPermission> Permissions { get; set; }

        public IEnumerable<IPermission> PermissionsEnumerable { set => Permissions = value.ToList(); }
    }
}
