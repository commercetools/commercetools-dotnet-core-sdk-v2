using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.DeliveryAddedMessagePayload))]
    public partial interface IDeliveryAddedMessagePayload : IOrderMessagePayload
    {
        IDelivery Delivery { get; set; }

    }
}
