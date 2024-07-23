namespace commercetools.Sdk.Api.Models.StandalonePrices
{

    public partial class StandalonePriceRemovePriceTierAction : IStandalonePriceRemovePriceTierAction
    {
        public string Action { get; set; }

        public long TierMinimumQuantity { get; set; }
        public StandalonePriceRemovePriceTierAction()
        {
            this.Action = "removePriceTier";
        }
    }
}
