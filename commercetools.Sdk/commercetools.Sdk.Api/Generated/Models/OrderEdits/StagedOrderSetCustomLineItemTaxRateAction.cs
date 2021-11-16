using commercetools.Api.Models.Carts;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetCustomLineItemTaxRateAction : IStagedOrderSetCustomLineItemTaxRateAction
    {
        public string Action { get; set; }

        public string CustomLineItemId { get; set; }

        public IExternalTaxRateDraft ExternalTaxRate { get; set; }
        public StagedOrderSetCustomLineItemTaxRateAction()
        {
            this.Action = "setCustomLineItemTaxRate";
        }
    }
}
