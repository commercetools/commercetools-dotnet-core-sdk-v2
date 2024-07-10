using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.StagedQuotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteStateChangedMessagePayload))]
    public partial interface IStagedQuoteStateChangedMessagePayload : IMessagePayload
    {
        IStagedQuoteState StagedQuoteState { get; set; }

        IStagedQuoteState OldStagedQuoteState { get; set; }

    }
}
