using commercetools.Sdk.Api.Models.QuoteRequests;
using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.QuoteRequests
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.QuoteRequests.QuoteRequestTransitionStateAction))]
    public partial interface IQuoteRequestTransitionStateAction : IQuoteRequestUpdateAction
    {
        IStateResourceIdentifier State { get; set; }

        bool? Force { get; set; }

    }
}
