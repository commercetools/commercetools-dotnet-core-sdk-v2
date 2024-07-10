using commercetools.Sdk.Api.Models.AssociateRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
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
