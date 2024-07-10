using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class AssociateRolePermissionsSetMessagePayload : IAssociateRolePermissionsSetMessagePayload
    {
        public string Type { get; set; }

        public IList<IPermission> Permissions { get; set; }
        public IEnumerable<IPermission> PermissionsEnumerable { set => Permissions = value.ToList(); }

        public AssociateRolePermissionsSetMessagePayload()
        {
            this.Type = "AssociateRolePermissionsSet";
        }
    }
}
