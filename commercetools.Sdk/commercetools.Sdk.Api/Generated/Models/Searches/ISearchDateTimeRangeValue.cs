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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchDateTimeRangeValue))]
    public partial interface ISearchDateTimeRangeValue : ISearchQueryExpressionValue
    {
        DateTime? Gte { get; set; }

        DateTime? Gt { get; set; }

        DateTime? Lte { get; set; }

        DateTime? Lt { get; set; }

    }
}
