using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryCustomTypeRemovedMessage))]
    public partial interface IDeliveryCustomTypeRemovedMessage : IOrderMessage
    {
        string PreviousTypeId { get; set; }

        string DeliveryId { get; set; }

    }
}
