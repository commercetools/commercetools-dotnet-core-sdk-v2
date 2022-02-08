using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderStateChangedMessage))]
    public partial interface IOrderStateChangedMessage : IOrderMessage
    {
        IOrderState OrderState { get; set; }

        IOrderState OldOrderState { get; set; }
    }
}
