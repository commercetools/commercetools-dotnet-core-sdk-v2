using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchAnyValue))]
    public partial interface ISearchAnyValue : ISearchQueryExpressionValue
    {
        Object Value { get; set; }

        string Language { get; set; }

        bool? CaseInsensitive { get; set; }

    }
}
