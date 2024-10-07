using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CustomerCustomTypeRemovedMessage))]
    public partial interface ICustomerCustomTypeRemovedMessage : IMessage
    {
        string PreviousTypeId { get; set; }

    }
}
