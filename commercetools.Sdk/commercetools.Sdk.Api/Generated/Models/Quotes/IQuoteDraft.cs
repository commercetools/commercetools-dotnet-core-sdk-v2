using commercetools.Sdk.Api.Models.StagedQuotes;
using commercetools.Sdk.Api.Models.States;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteDraft))]
    public partial interface IQuoteDraft
    {
        string Key { get; set; }

        IStagedQuoteResourceIdentifier StagedQuote { get; set; }

        long StagedQuoteVersion { get; set; }

        bool? StagedQuoteStateToSent { get; set; }

        IStateReference State { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
