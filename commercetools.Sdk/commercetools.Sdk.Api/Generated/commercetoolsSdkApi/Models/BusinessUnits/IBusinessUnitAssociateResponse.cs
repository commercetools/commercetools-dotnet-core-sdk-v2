using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Sdk.Api.Models.Customers;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.BusinessUnits
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.BusinessUnits.BusinessUnitAssociateResponse))]
    public partial interface IBusinessUnitAssociateResponse
    {
        ICustomerReference Customer { get; set; }

        IList<IAssociateRole> AssociateRoles { get; set; }

        IEnumerable<IAssociateRole> AssociateRolesEnumerable { set => AssociateRoles = value.ToList(); }

        IList<IAssociateRole> InheritedAssociateRoles { get; set; }

        IEnumerable<IAssociateRole> InheritedAssociateRolesEnumerable { set => InheritedAssociateRoles = value.ToList(); }

        IList<IPermission> Permissions { get; set; }

        IEnumerable<IPermission> PermissionsEnumerable { set => Permissions = value.ToList(); }

    }
}
