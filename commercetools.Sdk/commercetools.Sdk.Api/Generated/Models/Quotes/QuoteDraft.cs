using commercetools.Sdk.Api.Models.StagedQuotes;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Quotes
{

    public partial class QuoteDraft : IQuoteDraft
    {
        public string Key { get; set; }

        public IStagedQuoteResourceIdentifier StagedQuote { get; set; }

        public long StagedQuoteVersion { get; set; }

        public bool? StagedQuoteStateToSent { get; set; }

        public IStateReference State { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
    }
}
