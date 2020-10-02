using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.States
{
    [DiscriminatorValue("setRoles")]
    public partial class StateSetRolesAction : StateUpdateAction
    {
        public List<string> Roles { get; set;}
        
        [JsonIgnore]
        public List<StateRoleEnum> RolesAsEnum => this.Roles.GetEnum<StateRoleEnum>();
        public StateSetRolesAction()
        { 
           this.Action = "setRoles";
        }
    }
}
