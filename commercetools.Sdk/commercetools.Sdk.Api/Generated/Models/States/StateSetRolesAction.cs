using System.Collections.Generic;


namespace commercetools.Api.Models.States
{
    public partial class StateSetRolesAction : IStateSetRolesAction
    {
        public string Action { get; set; }

        public List<IStateRoleEnum> Roles { get; set; }
        public StateSetRolesAction()
        {
            this.Action = "setRoles";
        }
    }
}
