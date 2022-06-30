namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class StagedQuoteDeletedMessagePayload : IStagedQuoteDeletedMessagePayload
    {
        public string Type { get; set; }
        public StagedQuoteDeletedMessagePayload()
        {
            this.Type = "StagedQuoteDeleted";
        }
    }
}
