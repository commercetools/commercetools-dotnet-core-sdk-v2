using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemAddedMessagePayload))]
    public partial interface IOrderCustomLineItemAddedMessagePayload : IOrderMessagePayload
    {
        ICustomLineItem CustomLineItem { get; set; }

    }
}
