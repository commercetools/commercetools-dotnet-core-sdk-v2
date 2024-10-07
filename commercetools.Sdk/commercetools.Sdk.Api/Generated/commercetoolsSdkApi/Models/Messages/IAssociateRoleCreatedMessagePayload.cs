using commercetools.Sdk.Api.Models.AssociateRoles;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRoleCreatedMessagePayload))]
    public partial interface IAssociateRoleCreatedMessagePayload : IMessagePayload
    {
        IAssociateRole AssociateRole { get; set; }

    }
}
