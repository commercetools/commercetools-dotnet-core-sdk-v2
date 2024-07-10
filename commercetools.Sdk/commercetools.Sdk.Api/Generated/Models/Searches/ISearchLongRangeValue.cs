using commercetools.Sdk.Api.Models.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchLongRangeValue))]
    public partial interface ISearchLongRangeValue : ISearchQueryExpressionValue
    {
        long? Gte { get; set; }

        long? Gt { get; set; }

        long? Lte { get; set; }

        long? Lt { get; set; }

    }
}
