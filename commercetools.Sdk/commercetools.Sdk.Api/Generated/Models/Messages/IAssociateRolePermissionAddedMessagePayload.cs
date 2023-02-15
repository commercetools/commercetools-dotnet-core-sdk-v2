using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRolePermissionAddedMessagePayload))]
    public partial interface IAssociateRolePermissionAddedMessagePayload : IMessagePayload
    {
        IPermission Permission { get; set; }

    }
}
