namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class QuoteRequestCreatedMessagePayload : IQuoteRequestCreatedMessagePayload
    {
        public string Type { get; set; }
        public QuoteRequestCreatedMessagePayload()
        {
            this.Type = "QuoteRequestCreated";
        }
    }
}
