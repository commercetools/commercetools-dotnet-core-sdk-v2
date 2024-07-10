using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.StagedQuotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class StagedQuoteCreatedMessagePayload : IStagedQuoteCreatedMessagePayload
    {
        public string Type { get; set; }

        public IStagedQuote StagedQuote { get; set; }
        public StagedQuoteCreatedMessagePayload()
        {
            this.Type = "StagedQuoteCreated";
        }
    }
}
