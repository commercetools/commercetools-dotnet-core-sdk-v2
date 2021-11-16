using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderStateChangedMessagePayload))]
    public partial interface IOrderStateChangedMessagePayload : IMessagePayload
    {
        IOrderState OrderState { get; set; }

        IOrderState OldOrderState { get; set; }
    }
}
