using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleDraft : IAssociateRoleDraft
    {
        public string Key { get; set; }

        public string Name { get; set; }

        public bool? BuyerAssignable { get; set; }

        public IList<IPermission> Permissions { get; set; }

        public IEnumerable<IPermission> PermissionsEnumerable { set => Permissions = value.ToList(); }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
