using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomFieldRemovedMessage))]
    public partial interface IOrderCustomFieldRemovedMessage : IOrderMessage
    {
        string Name { get; set; }

    }
}
