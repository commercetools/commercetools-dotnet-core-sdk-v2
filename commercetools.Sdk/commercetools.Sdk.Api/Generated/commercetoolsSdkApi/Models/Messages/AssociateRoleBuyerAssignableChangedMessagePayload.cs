

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class AssociateRoleBuyerAssignableChangedMessagePayload : IAssociateRoleBuyerAssignableChangedMessagePayload
    {
        public string Type { get; set; }

        public bool BuyerAssignable { get; set; }
        public AssociateRoleBuyerAssignableChangedMessagePayload()
        {
            this.Type = "AssociateRoleBuyerAssignableChanged";
        }
    }
}
