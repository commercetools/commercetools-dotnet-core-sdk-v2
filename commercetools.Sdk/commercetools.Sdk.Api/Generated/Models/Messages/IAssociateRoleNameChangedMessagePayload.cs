using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRoleNameChangedMessagePayload))]
    public partial interface IAssociateRoleNameChangedMessagePayload : IMessagePayload
    {
        string Name { get; set; }

    }
}
