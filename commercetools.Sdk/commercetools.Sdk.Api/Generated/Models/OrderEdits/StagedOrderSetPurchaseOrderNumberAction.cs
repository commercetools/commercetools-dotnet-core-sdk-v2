namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetPurchaseOrderNumberAction : IStagedOrderSetPurchaseOrderNumberAction
    {
        public string Action { get; set; }

        public string PurchaseOrderNumber { get; set; }
        public StagedOrderSetPurchaseOrderNumberAction()
        {
            this.Action = "setPurchaseOrderNumber";
        }
    }
}
