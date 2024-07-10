using commercetools.Sdk.Api.Models.AssociateRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleSetCustomFieldAction : IAssociateRoleSetCustomFieldAction
    {
        public string Action { get; set; }

        public string Name { get; set; }

        public Object Value { get; set; }
        public AssociateRoleSetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }
    }
}
