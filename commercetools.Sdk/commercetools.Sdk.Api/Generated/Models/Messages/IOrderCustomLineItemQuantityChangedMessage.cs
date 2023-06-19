using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderCustomLineItemQuantityChangedMessage))]
    public partial interface IOrderCustomLineItemQuantityChangedMessage : IOrderMessage
    {
        string CustomLineItemId { get; set; }

        long Quantity { get; set; }

        long OldQuantity { get; set; }

    }
}
