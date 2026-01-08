

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CartPurchaseOrderNumberSetMessagePayload : ICartPurchaseOrderNumberSetMessagePayload
    {
        public string Type { get; set; }

        public string PurchaseOrderNumber { get; set; }

        public string OldPurchaseOrderNumber { get; set; }
        public CartPurchaseOrderNumberSetMessagePayload()
        {
            this.Type = "CartPurchaseOrderNumberSet";
        }
    }
}
