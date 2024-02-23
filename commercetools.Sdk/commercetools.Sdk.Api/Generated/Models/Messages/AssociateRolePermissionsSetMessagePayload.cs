using commercetools.Sdk.Api.Models.AssociateRoles;
using System.Collections.Generic;
using System.Linq;


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
