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
        public string Action { get; set; }

        public List<IStateRoleEnum> Roles { get; set; }
        public StateSetRolesAction()
        {
            this.Action = "setRoles";
        }
    }
}
