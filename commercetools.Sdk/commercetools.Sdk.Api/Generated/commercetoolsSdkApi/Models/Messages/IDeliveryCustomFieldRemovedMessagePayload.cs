using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryCustomFieldRemovedMessagePayload))]
    public partial interface IDeliveryCustomFieldRemovedMessagePayload : IOrderMessagePayload
    {
        string Name { get; set; }

        string DeliveryId { get; set; }

    }
}
