using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceExternalDiscountSetMessagePayload : IStandalonePriceExternalDiscountSetMessagePayload
    {
        public string Type { get; set; }

        public IDiscountedPrice Discounted { get; set; }
        public StandalonePriceExternalDiscountSetMessagePayload()
        {
            this.Type = "StandalonePriceExternalDiscountSet";
        }
    }
}
