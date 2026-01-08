

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartSetPurchaseOrderNumberAction : ICartSetPurchaseOrderNumberAction
    {
        public string Action { get; set; }

        public string PurchaseOrderNumber { get; set; }
        public CartSetPurchaseOrderNumberAction()
        {
            this.Action = "setPurchaseOrderNumber";
        }
    }
}
