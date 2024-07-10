using commercetools.Sdk.Api.Models.AssociateRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleRemovePermissionAction : IAssociateRoleRemovePermissionAction
    {
        public string Action { get; set; }

        public IPermission Permission { get; set; }
        public AssociateRoleRemovePermissionAction()
        {
            this.Action = "removePermission";
        }
    }
}
