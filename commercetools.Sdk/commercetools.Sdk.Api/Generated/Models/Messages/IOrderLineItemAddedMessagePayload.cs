using commercetools.Sdk.Api.Models.Carts;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderLineItemAddedMessagePayload))]
    public partial interface IOrderLineItemAddedMessagePayload : IOrderMessagePayload
    {
        ILineItem LineItem { get; set; }

        long AddedQuantity { get; set; }
    }
}
