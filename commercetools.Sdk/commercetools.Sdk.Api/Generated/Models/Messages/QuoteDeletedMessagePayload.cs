namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class QuoteDeletedMessagePayload : IQuoteDeletedMessagePayload
    {
        public string Type { get; set; }
        public QuoteDeletedMessagePayload()
        {
            this.Type = "QuoteDeleted";
        }
    }
}
