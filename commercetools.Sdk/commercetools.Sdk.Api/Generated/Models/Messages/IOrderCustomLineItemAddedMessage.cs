using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemAddedMessage))]
    public partial interface IOrderCustomLineItemAddedMessage : IOrderMessage
    {
        ICustomLineItem CustomLineItem { get; set; }

    }
}
