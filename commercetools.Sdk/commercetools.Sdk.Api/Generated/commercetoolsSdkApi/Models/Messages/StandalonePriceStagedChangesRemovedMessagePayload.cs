using commercetools.Sdk.Api.Models.StandalonePrices;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceStagedChangesRemovedMessagePayload : IStandalonePriceStagedChangesRemovedMessagePayload
    {
        public string Type { get; set; }

        public IStagedStandalonePrice StagedChanges { get; set; }
        public StandalonePriceStagedChangesRemovedMessagePayload()
        {
            this.Type = "StandalonePriceStagedChangesRemoved";
        }
    }
}
