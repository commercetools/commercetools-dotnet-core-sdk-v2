using commercetools.Sdk.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.ReturnInfoAddedMessage))]
    public partial interface IReturnInfoAddedMessage : IOrderMessage
    {
        IReturnInfo ReturnInfo { get; set; }

    }
}
