using commercetools.Sdk.Api.Models.Common;
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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.StagedQuoteStateChangedMessage))]
    public partial interface IStagedQuoteStateChangedMessage : IMessage
    {
        IStagedQuoteState StagedQuoteState { get; set; }

        IStagedQuoteState OldStagedQuoteState { get; set; }

    }
}
