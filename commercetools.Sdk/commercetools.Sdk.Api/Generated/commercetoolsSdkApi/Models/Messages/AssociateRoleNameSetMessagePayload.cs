

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class AssociateRoleNameSetMessagePayload : IAssociateRoleNameSetMessagePayload
    {
        public string Type { get; set; }

        public string Name { get; set; }
        public AssociateRoleNameSetMessagePayload()
        {
            this.Type = "AssociateRoleNameSet";
        }
    }
}
