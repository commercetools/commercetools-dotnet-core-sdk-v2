using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderPurchaseOrderNumberSetMessage))]
    public partial interface IOrderPurchaseOrderNumberSetMessage : IOrderMessage
    {
        string PurchaseOrderNumber { get; set; }

        string OldPurchaseOrderNumber { get; set; }

    }
}
