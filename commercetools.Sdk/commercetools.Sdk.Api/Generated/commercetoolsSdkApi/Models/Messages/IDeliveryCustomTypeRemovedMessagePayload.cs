using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryCustomTypeRemovedMessagePayload))]
    public partial interface IDeliveryCustomTypeRemovedMessagePayload : IOrderMessagePayload
    {
        string PreviousTypeId { get; set; }

        string DeliveryId { get; set; }

    }
}
