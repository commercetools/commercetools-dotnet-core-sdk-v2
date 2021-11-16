using System.Collections.Generic;


namespace commercetools.Api.Models.States
{
    public partial class StateRemoveRolesAction : IStateRemoveRolesAction
    {
        public string Action { get; set;}
        
        public List<IStateRoleEnum> Roles { get; set;}
        public StateRemoveRolesAction()
        { 
           this.Action = "removeRoles";
        }
    }
}
