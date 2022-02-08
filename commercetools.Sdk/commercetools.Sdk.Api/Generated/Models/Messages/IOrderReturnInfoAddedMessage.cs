using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderReturnInfoAddedMessage))]
    public partial interface IOrderReturnInfoAddedMessage : IOrderMessage
    {
        IReturnInfo ReturnInfo { get; set; }
    }
}
