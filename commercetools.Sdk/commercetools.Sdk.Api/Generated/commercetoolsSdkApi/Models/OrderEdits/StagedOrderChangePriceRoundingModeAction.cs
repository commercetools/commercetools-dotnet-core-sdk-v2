using commercetools.Sdk.Api.Models.Carts;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderChangePriceRoundingModeAction : IStagedOrderChangePriceRoundingModeAction
    {
        public string Action { get; set; }

        public IRoundingMode PriceRoundingMode { get; set; }
        public StagedOrderChangePriceRoundingModeAction()
        {
            this.Action = "changePriceRoundingMode";
        }
    }
}
