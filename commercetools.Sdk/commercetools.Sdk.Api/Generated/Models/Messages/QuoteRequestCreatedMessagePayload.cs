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

    public partial class QuoteRequestCreatedMessagePayload : IQuoteRequestCreatedMessagePayload
    {
        public string Type { get; set; }

        public IQuoteRequest QuoteRequest { get; set; }
        public QuoteRequestCreatedMessagePayload()
        {
            this.Type = "QuoteRequestCreated";
        }
    }
}
