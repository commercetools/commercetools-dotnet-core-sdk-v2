using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.StandalonePrices
{
    public partial class StandalonePriceSetDiscountedPriceAction : IStandalonePriceSetDiscountedPriceAction
    {
        public string Action { get; set; }

        public IDiscountedPriceDraft Discounted { get; set; }
        public StandalonePriceSetDiscountedPriceAction()
        {
            this.Action = "setDiscountedPrice";
        }
    }
}
