using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleUpdate))]
    public partial interface IAssociateRoleUpdate
    {
        long Version { get; set; }

        IList<IAssociateRoleUpdateAction> Actions { get; set; }
        IEnumerable<IAssociateRoleUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
