using commercetools.Sdk.Api.Models.QuoteRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.QuoteRequests
{

    public partial class QuoteRequestChangeQuoteRequestStateAction : IQuoteRequestChangeQuoteRequestStateAction
    {
        public string Action { get; set; }

        public IQuoteRequestState QuoteRequestState { get; set; }
        public QuoteRequestChangeQuoteRequestStateAction()
        {
            this.Action = "changeQuoteRequestState";
        }
    }
}
