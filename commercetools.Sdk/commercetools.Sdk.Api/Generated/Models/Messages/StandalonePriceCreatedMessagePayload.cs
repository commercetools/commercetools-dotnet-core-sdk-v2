using commercetools.Sdk.Api.Models.StandalonePrices;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceCreatedMessagePayload : IStandalonePriceCreatedMessagePayload
    {
        public string Type { get; set; }

        public IStandalonePrice StandalonePrice { get; set; }
        public StandalonePriceCreatedMessagePayload()
        {
            this.Type = "StandalonePriceCreated";
        }
    }
}
