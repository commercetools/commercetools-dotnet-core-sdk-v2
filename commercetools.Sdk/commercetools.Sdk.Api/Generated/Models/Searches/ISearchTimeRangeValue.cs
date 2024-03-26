using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchTimeRangeValue))]
    public partial interface ISearchTimeRangeValue : ISearchQueryExpressionValue
    {
        TimeSpan? Gte { get; set; }

        TimeSpan? Gt { get; set; }

        TimeSpan? Lte { get; set; }

        TimeSpan? Lt { get; set; }

    }
}
