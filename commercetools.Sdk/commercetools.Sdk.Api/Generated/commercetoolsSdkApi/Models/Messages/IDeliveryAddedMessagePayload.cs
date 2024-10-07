using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryAddedMessagePayload))]
    public partial interface IDeliveryAddedMessagePayload : IOrderMessagePayload
    {
        IDelivery Delivery { get; set; }

        string ShippingKey { get; set; }

    }
}
