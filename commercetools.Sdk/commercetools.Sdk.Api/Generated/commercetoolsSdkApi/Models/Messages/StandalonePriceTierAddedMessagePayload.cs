using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceTierAddedMessagePayload : IStandalonePriceTierAddedMessagePayload
    {
        public string Type { get; set; }

        public IPriceTier Tier { get; set; }
        public StandalonePriceTierAddedMessagePayload()
        {
            this.Type = "StandalonePriceTierAdded";
        }
    }
}
