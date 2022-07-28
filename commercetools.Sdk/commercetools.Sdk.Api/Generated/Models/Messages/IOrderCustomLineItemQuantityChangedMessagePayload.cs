using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemQuantityChangedMessagePayload))]
    public partial interface IOrderCustomLineItemQuantityChangedMessagePayload : IOrderMessagePayload
    {
        string CustomLineItemId { get; set; }

        long Quantity { get; set; }

        long OldQuantity { get; set; }

    }
}
