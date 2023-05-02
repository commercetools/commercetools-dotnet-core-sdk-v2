using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionRemovedMessagePayload))]
    public partial interface IAssociateRolePermissionRemovedMessagePayload : IMessagePayload
    {
        IPermission Permission { get; set; }

    }
}
