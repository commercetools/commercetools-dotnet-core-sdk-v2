using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.StagedQuotes
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.StagedQuotes.StagedQuoteSetCustomFieldAction))]
    public partial interface IStagedQuoteSetCustomFieldAction : IStagedQuoteUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }

    }
}
