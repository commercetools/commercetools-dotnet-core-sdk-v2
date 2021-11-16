using commercetools.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderLineItemAddedMessage))]
    public partial interface IOrderLineItemAddedMessage : IMessage
    {
        ILineItem LineItem { get; set; }

        long AddedQuantity { get; set; }
    }
}
