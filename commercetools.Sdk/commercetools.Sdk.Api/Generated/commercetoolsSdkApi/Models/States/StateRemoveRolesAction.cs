using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.States
{

    public partial class StateRemoveRolesAction : IStateRemoveRolesAction
    {
        public string Action { get; set; }

        public IList<IStateRoleEnum> Roles { get; set; }

        public IEnumerable<IStateRoleEnum> RolesEnumerable { set => Roles = value.ToList(); }
        public StateRemoveRolesAction()
        {
            this.Action = "removeRoles";
        }
    }
}
