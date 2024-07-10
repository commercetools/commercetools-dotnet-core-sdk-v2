using commercetools.Sdk.Api.Models.Quotes;
using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Quotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Quotes.QuoteTransitionStateAction))]
    public partial interface IQuoteTransitionStateAction : IQuoteUpdateAction
    {
        IStateResourceIdentifier State { get; set; }

        bool? Force { get; set; }

    }
}
