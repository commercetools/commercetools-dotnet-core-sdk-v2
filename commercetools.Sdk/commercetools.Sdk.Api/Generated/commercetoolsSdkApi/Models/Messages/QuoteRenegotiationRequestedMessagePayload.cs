

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class QuoteRenegotiationRequestedMessagePayload : IQuoteRenegotiationRequestedMessagePayload
    {
        public string Type { get; set; }

        public string BuyerComment { get; set; }
        public QuoteRenegotiationRequestedMessagePayload()
        {
            this.Type = "QuoteRenegotiationRequested";
        }
    }
}
