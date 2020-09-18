using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("addRoles")]
    public class StateAddRolesAction : StateUpdateAction
    {
        public List<StateRoleEnum> Roles { get; set;}
    }
}
