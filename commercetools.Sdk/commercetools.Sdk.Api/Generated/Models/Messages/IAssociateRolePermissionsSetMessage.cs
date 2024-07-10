using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionsSetMessage))]
    public partial interface IAssociateRolePermissionsSetMessage : IMessage
    {
        IList<IPermission> Permissions { get; set; }
        IEnumerable<IPermission> PermissionsEnumerable { set => Permissions = value.ToList(); }


    }
}
