using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.QuoteRequestStateTransitionMessagePayload))]
    public partial interface IQuoteRequestStateTransitionMessagePayload : IMessagePayload
    {
        IStateReference State { get; set; }

        IStateReference OldState { get; set; }

        bool Force { get; set; }

    }
}
