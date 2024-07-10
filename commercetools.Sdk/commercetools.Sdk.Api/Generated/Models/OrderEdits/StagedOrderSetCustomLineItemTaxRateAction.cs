using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetCustomLineItemTaxRateAction : IStagedOrderSetCustomLineItemTaxRateAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public string CustomLineItemKey { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }

        public string ShippingKey { get; set; }
        public StagedOrderSetCustomLineItemTaxRateAction()
        {
            this.Action = "setCustomLineItemTaxRate";
        }
    }
}
