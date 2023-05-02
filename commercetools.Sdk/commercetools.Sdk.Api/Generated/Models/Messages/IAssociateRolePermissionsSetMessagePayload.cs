using commercetools.Sdk.Api.Models.AssociateRoles;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionsSetMessagePayload))]
    public partial interface IAssociateRolePermissionsSetMessagePayload : IMessagePayload
    {
        IList<IPermission> Permissions { get; set; }
        IEnumerable<IPermission> PermissionsEnumerable { set => Permissions = value.ToList(); }


    }
}
