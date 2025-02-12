using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.AssociateRoleNameSetMessagePayload))]
    public partial interface IAssociateRoleNameSetMessagePayload : IMessagePayload
    {
        string Name { get; set; }

    }
}
