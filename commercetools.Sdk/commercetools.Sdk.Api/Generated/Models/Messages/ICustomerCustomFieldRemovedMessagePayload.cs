using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerCustomFieldRemovedMessagePayload))]
    public partial interface ICustomerCustomFieldRemovedMessagePayload : IMessagePayload
    {
        string Name { get; set; }

    }
}
