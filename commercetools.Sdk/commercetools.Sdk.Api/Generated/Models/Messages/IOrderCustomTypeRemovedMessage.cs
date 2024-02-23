using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomTypeRemovedMessage))]
    public partial interface IOrderCustomTypeRemovedMessage : IOrderMessage
    {
        string PreviousTypeId { get; set; }

    }
}
