using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.States
{

    public partial class StateAddRolesAction : IStateAddRolesAction
    {
        public string Action { get; set; }

        public List<IStateRoleEnum> Roles { get; set; }
        public StateAddRolesAction()
        {
            this.Action = "addRoles";
        }
    }
}
