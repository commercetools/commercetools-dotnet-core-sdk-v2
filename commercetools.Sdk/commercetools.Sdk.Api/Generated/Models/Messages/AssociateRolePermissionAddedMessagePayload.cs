using commercetools.Sdk.Api.Models.AssociateRoles;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class AssociateRolePermissionAddedMessagePayload : IAssociateRolePermissionAddedMessagePayload
    {
        public string Type { get; set; }

        public IPermission Permission { get; set; }
        public AssociateRolePermissionAddedMessagePayload()
        {
            this.Type = "AssociateRolePermissionAdded";
        }
    }
}
