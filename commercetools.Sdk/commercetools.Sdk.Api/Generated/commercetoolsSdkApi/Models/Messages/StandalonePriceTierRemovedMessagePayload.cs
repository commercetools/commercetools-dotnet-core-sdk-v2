using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceTierRemovedMessagePayload : IStandalonePriceTierRemovedMessagePayload
    {
        public string Type { get; set; }

        public IPriceTier RemovedTier { get; set; }
        public StandalonePriceTierRemovedMessagePayload()
        {
            this.Type = "StandalonePriceTierRemoved";
        }
    }
}
