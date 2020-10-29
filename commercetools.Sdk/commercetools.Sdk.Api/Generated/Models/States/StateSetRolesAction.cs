using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.States
{
    public partial class StateSetRolesAction : IStateSetRolesAction
    {
        public string Action { get; set;}
        
        public List<string> Roles { get; set;}
        
        [JsonIgnore]
        public List<StateRoleEnum> RolesAsEnum => this.Roles.GetEnum<StateRoleEnum>();
        public StateSetRolesAction()
        { 
           this.Action = "setRoles";
        }
    }
}
