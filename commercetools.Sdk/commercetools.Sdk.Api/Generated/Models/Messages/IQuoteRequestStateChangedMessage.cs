using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.QuoteRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestStateChangedMessage))]
    public partial interface IQuoteRequestStateChangedMessage : IMessage
    {
        IQuoteRequestState QuoteRequestState { get; set; }

        IQuoteRequestState OldQuoteRequestState { get; set; }

    }
}
