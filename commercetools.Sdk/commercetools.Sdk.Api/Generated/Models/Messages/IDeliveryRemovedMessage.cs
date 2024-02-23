using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryRemovedMessage))]
    public partial interface IDeliveryRemovedMessage : IOrderMessage
    {
        IDelivery Delivery { get; set; }

        string ShippingKey { get; set; }

    }
}
