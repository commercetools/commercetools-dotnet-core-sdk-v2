using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemQuantityChangedMessagePayload))]
    public partial interface IOrderCustomLineItemQuantityChangedMessagePayload : IOrderMessagePayload
    {
        string CustomLineItemId { get; set; }

        string CustomLineItemKey { get; set; }

        long Quantity { get; set; }

        long OldQuantity { get; set; }

    }
}
