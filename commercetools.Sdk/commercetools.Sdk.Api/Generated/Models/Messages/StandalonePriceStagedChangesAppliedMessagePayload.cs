using commercetools.Sdk.Api.Models.StandalonePrices;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StandalonePriceStagedChangesAppliedMessagePayload : IStandalonePriceStagedChangesAppliedMessagePayload
    {
        public string Type { get; set; }

        public IStagedStandalonePrice StagedChanges { get; set; }
        public StandalonePriceStagedChangesAppliedMessagePayload()
        {
            this.Type = "StandalonePriceStagedChangesApplied";
        }
    }
}
