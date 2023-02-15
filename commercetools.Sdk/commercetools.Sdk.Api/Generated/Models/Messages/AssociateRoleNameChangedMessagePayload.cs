namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class AssociateRoleNameChangedMessagePayload : IAssociateRoleNameChangedMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }
        public AssociateRoleNameChangedMessagePayload()
        {
            this.Type = "AssociateRoleNameChanged";
        }
    }
}
