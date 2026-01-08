using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.CartPurchaseOrderNumberSetMessage))]
    public partial interface ICartPurchaseOrderNumberSetMessage : IMessage
    {
        string PurchaseOrderNumber { get; set; }

        string OldPurchaseOrderNumber { get; set; }

    }
}
