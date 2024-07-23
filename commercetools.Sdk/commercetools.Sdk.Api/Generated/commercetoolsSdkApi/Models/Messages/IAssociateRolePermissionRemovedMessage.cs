using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionRemovedMessage))]
    public partial interface IAssociateRolePermissionRemovedMessage : IMessage
    {
        IPermission Permission { get; set; }

    }
}
