using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceAddPriceTierAction : IStandalonePriceAddPriceTierAction
    {
        public string Action { get; set; }

        public IPriceTierDraft Tier { get; set; }
        public StandalonePriceAddPriceTierAction()
        {
            this.Action = "addPriceTier";
        }
    }
}
