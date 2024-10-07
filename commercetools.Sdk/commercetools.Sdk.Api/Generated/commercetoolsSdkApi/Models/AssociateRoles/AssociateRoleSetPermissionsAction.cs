using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleSetPermissionsAction : IAssociateRoleSetPermissionsAction
    {
        public string Action { get; set; }

        public IList<IPermission> Permissions { get; set; }

        public IEnumerable<IPermission> PermissionsEnumerable { set => Permissions = value.ToList(); }
        public AssociateRoleSetPermissionsAction()
        {
            this.Action = "setPermissions";
        }
    }
}
