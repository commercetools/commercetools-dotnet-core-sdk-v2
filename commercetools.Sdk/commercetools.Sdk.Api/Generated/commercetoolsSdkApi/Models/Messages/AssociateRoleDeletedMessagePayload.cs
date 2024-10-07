

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class AssociateRoleDeletedMessagePayload : IAssociateRoleDeletedMessagePayload
    {
        public string Type { get; set; }
        public AssociateRoleDeletedMessagePayload()
        {
            this.Type = "AssociateRoleDeleted";
        }
    }
}
