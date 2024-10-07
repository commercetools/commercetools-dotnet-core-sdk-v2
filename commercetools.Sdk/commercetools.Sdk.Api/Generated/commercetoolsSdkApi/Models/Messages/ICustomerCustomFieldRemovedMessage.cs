using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldRemovedMessage))]
    public partial interface ICustomerCustomFieldRemovedMessage : IMessage
    {
        string Name { get; set; }

    }
}
