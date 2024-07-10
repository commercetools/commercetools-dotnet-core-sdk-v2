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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteUpdate))]
    public partial interface IQuoteUpdate
    {
        long Version { get; set; }

        IList<IQuoteUpdateAction> Actions { get; set; }
        IEnumerable<IQuoteUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
