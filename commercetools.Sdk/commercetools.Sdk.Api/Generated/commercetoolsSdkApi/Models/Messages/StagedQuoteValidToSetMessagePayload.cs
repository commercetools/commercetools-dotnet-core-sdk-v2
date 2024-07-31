using System;

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StagedQuoteValidToSetMessagePayload : IStagedQuoteValidToSetMessagePayload
    {
        public string Type { get; set; }

        public DateTime ValidTo { get; set; }
        public StagedQuoteValidToSetMessagePayload()
        {
            this.Type = "StagedQuoteValidToSet";
        }
    }
}
