using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderReturnInfoAddedMessagePayload))]
    public partial interface IOrderReturnInfoAddedMessagePayload : IMessagePayload
    {
        IReturnInfo ReturnInfo { get; set; }
    }
}
