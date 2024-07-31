

namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleAddPermissionAction : IAssociateRoleAddPermissionAction
    {
        public string Action { get; set; }

        public IPermission Permission { get; set; }
        public AssociateRoleAddPermissionAction()
        {
            this.Action = "addPermission";
        }
    }
}
