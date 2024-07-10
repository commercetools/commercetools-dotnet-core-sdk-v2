using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchFullTextPrefixValue))]
    public partial interface ISearchFullTextPrefixValue : ISearchQueryExpressionValue
    {
        Object Value { get; set; }

        string Language { get; set; }

        ISearchMatchType MustMatch { get; set; }

    }
}
