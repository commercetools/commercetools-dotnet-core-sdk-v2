using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchFuzzyValue))]
    public partial interface ISearchFuzzyValue : ISearchQueryExpressionValue
    {
        Object Value { get; set; }

        int Level { get; set; }

        string Language { get; set; }

        ISearchMatchType MustMatch { get; set; }

    }
}
