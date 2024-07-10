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

    public partial class StagedQuoteStateChangedMessagePayload : IStagedQuoteStateChangedMessagePayload
    {
        public string Type { get; set; }

        public IStagedQuoteState StagedQuoteState { get; set; }

        public IStagedQuoteState OldStagedQuoteState { get; set; }
        public StagedQuoteStateChangedMessagePayload()
        {
            this.Type = "StagedQuoteStateChanged";
        }
    }
}
