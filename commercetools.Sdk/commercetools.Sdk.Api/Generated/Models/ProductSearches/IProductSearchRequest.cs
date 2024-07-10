using commercetools.Sdk.Api.Models.ProductSearches;
using commercetools.Sdk.Api.Models.Searches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ProductSearches
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ProductSearches.ProductSearchRequest))]
    public partial interface IProductSearchRequest
    {
        ISearchQuery Query { get; set; }

        IList<ISearchSorting> Sort { get; set; }
        IEnumerable<ISearchSorting> SortEnumerable { set => Sort = value.ToList(); }


        int? Limit { get; set; }

        int? Offset { get; set; }

        bool? MarkMatchingVariants { get; set; }

        IProductSearchProjectionParams ProductProjectionParameters { get; set; }

        IList<IProductSearchFacetExpression> Facets { get; set; }
        IEnumerable<IProductSearchFacetExpression> FacetsEnumerable { set => Facets = value.ToList(); }


        ISearchQuery PostFilter { get; set; }

    }
}
