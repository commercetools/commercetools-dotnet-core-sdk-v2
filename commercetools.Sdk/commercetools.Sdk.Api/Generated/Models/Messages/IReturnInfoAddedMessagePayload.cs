using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ReturnInfoAddedMessagePayload))]
    public partial interface IReturnInfoAddedMessagePayload : IOrderMessagePayload
    {
        IReturnInfo ReturnInfo { get; set; }

    }
}
