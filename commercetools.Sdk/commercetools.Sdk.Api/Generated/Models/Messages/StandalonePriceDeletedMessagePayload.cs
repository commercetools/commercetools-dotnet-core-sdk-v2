namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class StandalonePriceDeletedMessagePayload : IStandalonePriceDeletedMessagePayload
    {
        public string Type { get; set; }
        public StandalonePriceDeletedMessagePayload()
        {
            this.Type = "StandalonePriceDeleted";
        }
    }
}
