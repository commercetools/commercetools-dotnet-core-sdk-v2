using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.QuoteRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class QuoteRequestStateChangedMessagePayload : IQuoteRequestStateChangedMessagePayload
    {
        public string Type { get; set; }

        public IQuoteRequestState QuoteRequestState { get; set; }

        public IQuoteRequestState OldQuoteRequestState { get; set; }
        public QuoteRequestStateChangedMessagePayload()
        {
            this.Type = "QuoteRequestStateChanged";
        }
    }
}
