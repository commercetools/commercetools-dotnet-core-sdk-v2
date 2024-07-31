

namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetPurchaseOrderNumberAction : IOrderSetPurchaseOrderNumberAction
    {
        public string Action { get; set; }

        public string PurchaseOrderNumber { get; set; }
        public OrderSetPurchaseOrderNumberAction()
        {
            this.Action = "setPurchaseOrderNumber";
        }
    }
}
