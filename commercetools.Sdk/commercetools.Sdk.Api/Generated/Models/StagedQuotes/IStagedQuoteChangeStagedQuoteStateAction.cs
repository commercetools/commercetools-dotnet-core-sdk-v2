using commercetools.Sdk.Api.Models.StagedQuotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteChangeStagedQuoteStateAction))]
    public partial interface IStagedQuoteChangeStagedQuoteStateAction : IStagedQuoteUpdateAction
    {
        IStagedQuoteState StagedQuoteState { get; set; }

    }
}
