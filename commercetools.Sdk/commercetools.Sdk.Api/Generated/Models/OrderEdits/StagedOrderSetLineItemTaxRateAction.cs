using commercetools.Api.Models.Carts;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetLineItemTaxRateAction : IStagedOrderSetLineItemTaxRateAction
    {
        public string Action { get; set; }

        public string LineItemId { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public StagedOrderSetLineItemTaxRateAction()
        {
            this.Action = "setLineItemTaxRate";
        }
    }
}
