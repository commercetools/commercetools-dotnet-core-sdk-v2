using System;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleSetCustomFieldAction : IAssociateRoleSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public AssociateRoleSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
