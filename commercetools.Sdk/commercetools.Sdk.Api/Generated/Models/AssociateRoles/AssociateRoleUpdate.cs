using commercetools.Sdk.Api.Models.AssociateRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{

    public partial class AssociateRoleUpdate : IAssociateRoleUpdate
    {
        public long Version { get; set; }

        public IList<IAssociateRoleUpdateAction> Actions { get; set; }
        public IEnumerable<IAssociateRoleUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }

    }
}
