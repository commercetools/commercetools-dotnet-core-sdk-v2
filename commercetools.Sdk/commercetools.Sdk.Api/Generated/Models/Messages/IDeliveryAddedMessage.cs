using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryAddedMessage))]
    public partial interface IDeliveryAddedMessage : IOrderMessage
    {
        IDelivery Delivery { get; set; }

        string ShippingKey { get; set; }

    }
}
