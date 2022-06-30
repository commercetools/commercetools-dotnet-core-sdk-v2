namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class QuoteRequestDeletedMessagePayload : IQuoteRequestDeletedMessagePayload
    {
        public string Type { get; set; }
        public QuoteRequestDeletedMessagePayload()
        {
            this.Type = "QuoteRequestDeleted";
        }
    }
}
