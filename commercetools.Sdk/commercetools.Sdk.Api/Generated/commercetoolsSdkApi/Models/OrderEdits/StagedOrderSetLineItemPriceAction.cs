using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetLineItemPriceAction : IStagedOrderSetLineItemPriceAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public string LineItemKey { get; set; }

        public IMoney ExternalPrice { get; set; }
        public StagedOrderSetLineItemPriceAction()
        {
            this.Action = "setLineItemPrice";
        }
    }
}
