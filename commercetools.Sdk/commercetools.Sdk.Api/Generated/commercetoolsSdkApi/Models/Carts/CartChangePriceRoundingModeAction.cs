

namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartChangePriceRoundingModeAction : ICartChangePriceRoundingModeAction
    {
        public string Action { get; set; }

        public IRoundingMode PriceRoundingMode { get; set; }
        public CartChangePriceRoundingModeAction()
        {
            this.Action = "changePriceRoundingMode";
        }
    }
}
