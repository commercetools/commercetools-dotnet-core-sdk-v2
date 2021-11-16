using commercetools.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderLineItemAddedMessagePayload))]
    public partial interface IOrderLineItemAddedMessagePayload : IMessagePayload
    {
        ILineItem LineItem { get; set;}
        
        long AddedQuantity { get; set;}
    }
}
