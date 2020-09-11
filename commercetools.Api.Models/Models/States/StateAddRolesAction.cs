using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.States
{
    public class StateAddRolesAction : StateUpdateAction
    {
        public List<StateRoleEnum> Roles { get; set;}
    }
}
