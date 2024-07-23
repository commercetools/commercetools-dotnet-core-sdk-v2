using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetPermissionsAction))]
    public partial interface IAssociateRoleSetPermissionsAction : IAssociateRoleUpdateAction
    {
        IList<IPermission> Permissions { get; set; }
        IEnumerable<IPermission> PermissionsEnumerable { set => Permissions = value.ToList(); }


    }
}
