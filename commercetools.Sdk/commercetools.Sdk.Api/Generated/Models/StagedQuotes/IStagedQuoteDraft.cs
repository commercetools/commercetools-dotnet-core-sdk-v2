using commercetools.Sdk.Api.Models.QuoteRequests;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteDraft))]
    public partial interface IStagedQuoteDraft
    {
        IQuoteRequestResourceIdentifier QuoteRequest { get; set; }

        long QuoteRequestVersion { get; set; }

        bool? QuoteRequestStateToAccepted { get; set; }

        string Key { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        IStateReference State { get; set; }

    }
}
