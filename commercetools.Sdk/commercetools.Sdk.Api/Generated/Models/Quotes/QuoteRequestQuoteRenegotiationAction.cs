using commercetools.Sdk.Api.Models.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteRequestQuoteRenegotiationAction : IQuoteRequestQuoteRenegotiationAction
    {
        public string Action { get; set; }

        public string BuyerComment { get; set; }
        public QuoteRequestQuoteRenegotiationAction()
        {
            this.Action = "requestQuoteRenegotiation";
        }
    }
}
