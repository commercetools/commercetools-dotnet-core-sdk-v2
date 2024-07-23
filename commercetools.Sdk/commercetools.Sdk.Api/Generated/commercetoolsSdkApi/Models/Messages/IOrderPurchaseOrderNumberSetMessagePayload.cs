using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.OrderPurchaseOrderNumberSetMessagePayload))]
    public partial interface IOrderPurchaseOrderNumberSetMessagePayload : IOrderMessagePayload
    {
        string PurchaseOrderNumber { get; set; }

        string OldPurchaseOrderNumber { get; set; }

    }
}
