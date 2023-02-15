using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRoleCreatedMessage))]
    public partial interface IAssociateRoleCreatedMessage : IMessage
    {
        IAssociateRole AssociateRole { get; set; }

    }
}
