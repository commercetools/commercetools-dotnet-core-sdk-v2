using commercetools.Sdk.Api.Models.QuoteRequests;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.StagedQuotes
{

    public partial class StagedQuoteDraft : IStagedQuoteDraft
    {
        public IQuoteRequestResourceIdentifier QuoteRequest { get; set; }

        public long QuoteRequestVersion { get; set; }

        public bool? QuoteRequestStateToAccepted { get; set; }

        public string Key { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public IStateReference State { get; set; }
    }
}
