using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerGroupCustomFieldRemovedMessage))]
    public partial interface ICustomerGroupCustomFieldRemovedMessage : IMessage
    {
        string Name { get; set; }

    }
}
