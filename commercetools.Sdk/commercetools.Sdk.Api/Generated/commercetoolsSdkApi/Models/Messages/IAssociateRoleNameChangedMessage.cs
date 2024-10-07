using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRoleNameChangedMessage))]
    public partial interface IAssociateRoleNameChangedMessage : IMessage
    {
        string Name { get; set; }

    }
}
