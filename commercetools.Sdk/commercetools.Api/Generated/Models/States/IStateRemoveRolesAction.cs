using commercetools.Api.Generated.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.States
{
    public interface IStateRemoveRolesAction : IStateUpdateAction
    {
        List<string> Roles { get; set;}
        
        List<StateRoleEnum> RolesAsEnum { get; }
    }
}
