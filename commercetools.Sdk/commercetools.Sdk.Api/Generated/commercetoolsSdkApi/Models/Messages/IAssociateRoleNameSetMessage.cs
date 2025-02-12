using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRoleNameSetMessage))]
    public partial interface IAssociateRoleNameSetMessage : IMessage
    {
        string Name { get; set; }

    }
}
