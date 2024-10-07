

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StagedQuoteSellerCommentSetMessagePayload : IStagedQuoteSellerCommentSetMessagePayload
    {
        public string Type { get; set; }

        public string SellerComment { get; set; }
        public StagedQuoteSellerCommentSetMessagePayload()
        {
            this.Type = "StagedQuoteSellerCommentSet";
        }
    }
}
