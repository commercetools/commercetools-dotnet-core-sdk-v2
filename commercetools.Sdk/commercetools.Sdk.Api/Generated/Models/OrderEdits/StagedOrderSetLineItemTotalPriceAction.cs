using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetLineItemTotalPriceAction : IStagedOrderSetLineItemTotalPriceAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }
        public StagedOrderSetLineItemTotalPriceAction()
        {
            this.Action = "setLineItemTotalPrice";
        }
    }
}
