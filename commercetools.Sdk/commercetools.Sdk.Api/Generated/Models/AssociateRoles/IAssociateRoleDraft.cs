using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleDraft))]
    public partial interface IAssociateRoleDraft
    {
        string Key { get; set; }

        string Name { get; set; }

        bool? BuyerAssignable { get; set; }

        IList<IPermission> Permissions { get; set; }
        IEnumerable<IPermission> PermissionsEnumerable { set => Permissions = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

    }
}
