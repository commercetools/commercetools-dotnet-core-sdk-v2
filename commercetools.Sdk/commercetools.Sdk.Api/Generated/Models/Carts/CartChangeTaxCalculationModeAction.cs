namespace commercetools.Sdk.Api.Models.Carts
{
    public partial class CartChangeTaxCalculationModeAction : ICartChangeTaxCalculationModeAction
    {
        public string Action { get; set; }

        public ITaxCalculationMode TaxCalculationMode { get; set; }
        public CartChangeTaxCalculationModeAction()
        {
            this.Action = "changeTaxCalculationMode";
        }
    }
}
