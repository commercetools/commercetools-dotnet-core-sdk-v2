using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderReturnInfoAddedMessagePayload))]
    public partial interface IOrderReturnInfoAddedMessagePayload : IOrderMessagePayload
    {
        IReturnInfo ReturnInfo { get; set; }

    }
}
