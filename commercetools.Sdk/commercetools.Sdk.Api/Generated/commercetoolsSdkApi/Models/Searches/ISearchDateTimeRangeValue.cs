using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchDateTimeRangeValue))]
    public partial interface ISearchDateTimeRangeValue : ISearchQueryExpressionValue
    {
        DateTime? Gte { get; set; }

        DateTime? Gt { get; set; }

        DateTime? Lte { get; set; }

        DateTime? Lt { get; set; }

    }
}
