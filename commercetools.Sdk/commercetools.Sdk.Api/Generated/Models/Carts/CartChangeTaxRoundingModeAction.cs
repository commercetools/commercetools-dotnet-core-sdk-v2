namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartChangeTaxRoundingModeAction : ICartChangeTaxRoundingModeAction
    {
        public string Action { get; set; }

        public IRoundingMode TaxRoundingMode { get; set; }
        public CartChangeTaxRoundingModeAction()
        {
            this.Action = "changeTaxRoundingMode";
        }
    }
}
