using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.AssociateRoles
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.AssociateRoles.AssociateRoleSetCustomFieldAction))]
    public partial interface IAssociateRoleSetCustomFieldAction : IAssociateRoleUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
