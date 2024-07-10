namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleChangeBuyerAssignableAction : IAssociateRoleChangeBuyerAssignableAction
    {
        public string Action { get; set; }

        public bool BuyerAssignable { get; set; }
        public AssociateRoleChangeBuyerAssignableAction()
        {
            this.Action = "changeBuyerAssignable";
        }
    }
}
