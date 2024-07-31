

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderPurchaseOrderNumberSetMessagePayload : IOrderPurchaseOrderNumberSetMessagePayload
    {
        public string Type { get; set; }

        public string PurchaseOrderNumber { get; set; }

        public string OldPurchaseOrderNumber { get; set; }
        public OrderPurchaseOrderNumberSetMessagePayload()
        {
            this.Type = "OrderPurchaseOrderNumberSet";
        }
    }
}
