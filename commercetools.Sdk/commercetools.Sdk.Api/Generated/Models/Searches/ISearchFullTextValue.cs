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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchFullTextValue))]
    public partial interface ISearchFullTextValue : ISearchQueryExpressionValue
    {
        Object Value { get; set; }

        string Language { get; set; }

        ISearchMatchType MustMatch { get; set; }

    }
}
