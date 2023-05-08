using commercetools.Sdk.Api.Models.AssociateRoles;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class AssociateRolePermissionRemovedMessagePayload : IAssociateRolePermissionRemovedMessagePayload
    {
        public string Type { get; set; }

        public IPermission Permission { get; set; }
        public AssociateRolePermissionRemovedMessagePayload()
        {
            this.Type = "AssociateRolePermissionRemoved";
        }
    }
}
