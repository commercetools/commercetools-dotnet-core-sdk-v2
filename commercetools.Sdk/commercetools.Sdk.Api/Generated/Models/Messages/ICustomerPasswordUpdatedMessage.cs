using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerPasswordUpdatedMessage))]
    public partial interface ICustomerPasswordUpdatedMessage : IMessage
    {
        bool Reset { get; set; }

    }
}
