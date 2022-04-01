using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.OrderEdits
{
    public partial class StagedOrderChangeTaxRoundingModeAction : IStagedOrderChangeTaxRoundingModeAction
    {
        public string Action { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }
        public StagedOrderChangeTaxRoundingModeAction()
        {
            this.Action = "changeTaxRoundingMode";
        }
    }
}
