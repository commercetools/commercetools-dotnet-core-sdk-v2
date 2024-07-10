using commercetools.Sdk.Api.Models.StagedQuotes;
using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteTransitionStateAction))]
    public partial interface IStagedQuoteTransitionStateAction : IStagedQuoteUpdateAction
    {
        IStateResourceIdentifier State { get; set; }

        bool? Force { get; set; }

    }
}
