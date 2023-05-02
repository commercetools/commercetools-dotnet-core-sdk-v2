using commercetools.Sdk.Api.Models.AssociateRoles;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class AssociateRoleCreatedMessagePayload : IAssociateRoleCreatedMessagePayload
    {
        public string Type { get; set; }

        public IAssociateRole AssociateRole { get; set; }
        public AssociateRoleCreatedMessagePayload()
        {
            this.Type = "AssociateRoleCreated";
        }
    }
}
