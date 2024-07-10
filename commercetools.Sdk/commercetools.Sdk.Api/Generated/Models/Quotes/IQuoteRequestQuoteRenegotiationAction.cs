using commercetools.Sdk.Api.Models.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteRequestQuoteRenegotiationAction))]
    public partial interface IQuoteRequestQuoteRenegotiationAction : IQuoteUpdateAction
    {
        string BuyerComment { get; set; }

    }
}
