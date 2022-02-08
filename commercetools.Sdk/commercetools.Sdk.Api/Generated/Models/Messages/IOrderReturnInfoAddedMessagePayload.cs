using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderReturnInfoAddedMessagePayload))]
    public partial interface IOrderReturnInfoAddedMessagePayload : IOrderMessagePayload
    {
        IReturnInfo ReturnInfo { get; set; }
    }
}
