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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Searches.SearchSorting))]
    public partial interface ISearchSorting
    {
        string Field { get; set; }

        string Language { get; set; }

        ISearchSortOrder Order { get; set; }

        ISearchSortMode Mode { get; set; }

        ISearchFieldType FieldType { get; set; }

        ISearchQueryExpression Filter { get; set; }

    }
}
