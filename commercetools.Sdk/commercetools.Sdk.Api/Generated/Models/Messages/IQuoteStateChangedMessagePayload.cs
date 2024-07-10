using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteStateChangedMessagePayload))]
    public partial interface IQuoteStateChangedMessagePayload : IMessagePayload
    {
        IQuoteState QuoteState { get; set; }

        IQuoteState OldQuoteState { get; set; }

    }
}
