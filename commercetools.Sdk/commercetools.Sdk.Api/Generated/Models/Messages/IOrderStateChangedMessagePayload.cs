using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderStateChangedMessagePayload))]
    public partial interface IOrderStateChangedMessagePayload : IOrderMessagePayload
    {
        IOrderState OrderState { get; set; }

        IOrderState OldOrderState { get; set; }
    }
}
