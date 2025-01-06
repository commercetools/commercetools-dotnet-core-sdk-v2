using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Searches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchExactValue))]
    public partial interface ISearchExactValue : ISearchQueryExpressionValue
    {
        Object Value { get; set; }

        IList<Object> Values { get; set; }

        IEnumerable<Object> ValuesEnumerable { set => Values = value.ToList(); }

        string Language { get; set; }

        bool? CaseInsensitive { get; set; }

    }
}
