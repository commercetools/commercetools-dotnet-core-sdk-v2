using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleSetCustomTypeAction : IAssociateRoleSetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public AssociateRoleSetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
