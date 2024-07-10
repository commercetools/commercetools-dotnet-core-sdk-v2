using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetValidToAction))]
    public partial interface IStagedQuoteSetValidToAction : IStagedQuoteUpdateAction
    {
        DateTime? ValidTo { get; set; }

    }
}
