using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class QuoteCreatedMessagePayload : IQuoteCreatedMessagePayload
    {
        public string Type { get; set; }

        public IQuote Quote { get; set; }
        public QuoteCreatedMessagePayload()
        {
            this.Type = "QuoteCreated";
        }
    }
}
