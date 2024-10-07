

namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleRemovePermissionAction : IAssociateRoleRemovePermissionAction
    {
        public string Action { get; set; }

        public IPermission Permission { get; set; }
        public AssociateRoleRemovePermissionAction()
        {
            this.Action = "removePermission";
        }
    }
}
