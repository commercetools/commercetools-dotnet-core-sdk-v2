using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderReturnInfoAddedMessage))]
    public partial interface IOrderReturnInfoAddedMessage : IOrderMessage
    {
        IReturnInfo ReturnInfo { get; set; }

    }
}
