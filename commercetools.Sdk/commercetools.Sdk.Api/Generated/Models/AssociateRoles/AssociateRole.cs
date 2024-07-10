using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRole : IAssociateRole
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public string Key { get; set; }

        public bool BuyerAssignable { get; set; }

        public string Name { get; set; }

        public IList<IPermission> Permissions { get; set; }
        public IEnumerable<IPermission> PermissionsEnumerable { set => Permissions = value.ToList(); }


        public ICustomFields Custom { get; set; }
    }
}
