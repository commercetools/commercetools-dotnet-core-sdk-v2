using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleUpdateAction : IAssociateRoleUpdateAction
    {
        public string Action { get; set; }
    }
}
