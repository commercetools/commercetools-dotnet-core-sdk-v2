using commercetools.Sdk.Api.Models.StagedQuotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteUpdate))]
    public partial interface IStagedQuoteUpdate
    {
        long Version { get; set; }

        IList<IStagedQuoteUpdateAction> Actions { get; set; }
        IEnumerable<IStagedQuoteUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
