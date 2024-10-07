

namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleSetNameAction : IAssociateRoleSetNameAction
    {
        public string Action { get; set; }

        public string Name { get; set; }
        public AssociateRoleSetNameAction()
        {
            this.Action = "setName";
        }
    }
}
