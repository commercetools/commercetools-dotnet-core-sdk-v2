using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class StandalonePriceDiscountSetMessagePayload : IStandalonePriceDiscountSetMessagePayload
    {
        public string Type { get; set; }

        public IDiscountedPrice Discounted { get; set; }
        public StandalonePriceDiscountSetMessagePayload()
        {
            this.Type = "StandalonePriceDiscountSet";
        }
    }
}
